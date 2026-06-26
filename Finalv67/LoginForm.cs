using System;
using System.Linq;
using System.Windows.Forms;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Database;
using Firebase.Database.Query;

namespace Finalv67
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        public static string TokenUsuarioActual = "";
        public static string UidUsuarioActual = "";
        public static string RolUsuarioActual = "";
        public static string CargoUsuarioActual = "";

        private async void btnIngresar_Click(object sender, EventArgs e)
        {

            btnIngresar.Enabled = false;
            btnIngresar.Text = "Validando...";

            try
            {
                var config = new FirebaseAuthConfig
                {
                    ApiKey = ConfiguracionFirebase.ApiKey,
                    AuthDomain = ConfiguracionFirebase.AuthDomain,
                    Providers = new FirebaseAuthProvider[] { new EmailProvider() }
                };

                var authClient = new FirebaseAuthClient(config);

                var userCredential = await authClient.SignInWithEmailAndPasswordAsync(txtUsuario.Text, txtContrasena.Text);
                ConexionFirebase.TokenGlobal = await userCredential.User.GetIdTokenAsync();

                var client = ConexionFirebase.Conectar();

                var usuariosNube = await client.Child("usuarios").OnceAsync<PersonalFirebase>();

                var usuarioEncontrado = usuariosNube.FirstOrDefault(u => u.Key == userCredential.User.Uid);
                UidUsuarioActual = userCredential.User.Uid;

                if (usuarioEncontrado != null)
                {
                    string rol = usuarioEncontrado.Object.rol?.ToLower();

                    RolUsuarioActual = usuarioEncontrado.Object.rol;
                    CargoUsuarioActual = usuarioEncontrado.Object.cargo;

                    if (rol == "admin")
                    {
                        string nombreAdmin = usuarioEncontrado.Object.nombre;
                        string correoAdmin = usuarioEncontrado.Object.correo;
                        string fotoAdmin = usuarioEncontrado.Object.foto;

                        Panel_Admin panel = new Panel_Admin(nombreAdmin, correoAdmin, fotoAdmin);

                        panel.FormClosed += (s, args) => Application.Exit();
                        panel.Show();
                    }
                    else
                    {
                        FormMenu principal = new FormMenu();
                        principal.FormClosed += (s, args) => Application.Exit();
                        principal.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario autenticado pero no encontrado en la base de datos.");
                    btnIngresar.Enabled = true;
                    btnIngresar.Text = "Ingresar";
                }
            }
            catch (FirebaseAuthException ex)
            {
                string mensajeError = "El usuario o la contraseña son incorrectos. Por favor, verifica tus datos.";
                if (ex.Reason == AuthErrorReason.Undefined)
                {
                    mensajeError = "No se pudo conectar con el servidor. Revisa tu conexión a internet.";
                }

                MessageBox.Show(mensajeError, "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnIngresar.Enabled = true;
                btnIngresar.Text = "Ingresar";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
                btnIngresar.Enabled = true;
                btnIngresar.Text = "Ingresar";
            }
        }
    }
}