using Firebase.Auth;
using Microsoft.JSInterop;
using Service.Models.Login;
using Service.Services;

namespace Web.Services
{
    public class FirebaseAuthService
    {
        private readonly IJSRuntime _jsRuntime;
        public event Action OnChangeLogin;
        public FirebaseUser CurrentUser { get; set; }

        public FirebaseAuthService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task<FirebaseUser?> SignInWithEmailPassword(string email, string password, bool rememberPassword)
        {
            var user = await _jsRuntime.InvokeAsync<FirebaseUser?>("firebaseAuth.signInWithEmailPassword", email, password, rememberPassword);
            if (user != null)
            {
                CurrentUser = user;
                OnChangeLogin?.Invoke();
            }
            return user;
        }

        public async Task<string> createUserWithEmailAndPassword(string email, string password, string displayName)
        {
            //Cuando crea un usuario no se loguea automáticamente. Lo crea y te lleva al login.
            var userId = await _jsRuntime.InvokeAsync<string>("firebaseAuth.createUserWithEmailAndPassword", email, password, displayName);
            if (userId != null)
            {
                OnChangeLogin?.Invoke();
            }
            return userId;
        }

        public async Task SignOut()
        {
            await _jsRuntime.InvokeVoidAsync("firebaseAuth.signOut");
            CurrentUser = null;
            OnChangeLogin?.Invoke();
        }

        public async Task<FirebaseUser?> GetUserFirebase()
        {
            //Devuelve el usuario logueado actualmente.
            //Email verified es para saber si el email fue verificado. Para que no pongan cualquier email.
            var userFirebase = await _jsRuntime.InvokeAsync<FirebaseUser>("firebaseAuth.getUserFirebase");
            if (userFirebase!=null && userFirebase.EmailVerified)
            {
                CurrentUser = userFirebase;
                return userFirebase;
            }
            else return null;

        }
        public async Task SetUserToken()
        {
            //Llamamos a la funcion creada en app.razor. Nos devuelve el token JWT.
            var jwt = await _jsRuntime.InvokeAsync<string?>("firebaseAuth.getUserToken");
            if (jwt != null)
            {
                //Si se obtuvo el token, lo asignamos a la propiedad estática jwtToken de GenericService.
                GenericService<Object>.jwtToken = jwt;
            }
        }

        public async Task<bool> IsUserAuthenticated()
        {
            //Este método verifica si hay un usuario autenticado. Autenticado es cuando el usuario ha iniciado sesión correctamente. Método que define si el usuario está logueado o no.
            var user = await GetUserFirebase();
            if (user != null)
            {
                //Si hay un usuario, obtenemos el token y lo seteamos en GenericService.
                await SetUserToken();
                //Invocamos para decir que ocurrió un cambio en el login.
                OnChangeLogin?.Invoke();
            }
            return user != null;
        }

        public async Task<FirebaseUser?> LoginWithGoogle()
        {
            var userFirebase = await _jsRuntime.InvokeAsync<FirebaseUser>("firebaseAuth.loginWithGoogle");
            CurrentUser = userFirebase;
            OnChangeLogin?.Invoke();
            return userFirebase;
        }
        //recuperar password
        public async Task<bool> RecoveryPassword(string email)
        {
            return await _jsRuntime.InvokeAsync<bool>("firebaseAuth.recoveryPassword", email);
        }
    }
}
