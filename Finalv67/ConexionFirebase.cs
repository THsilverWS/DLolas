using System;
using System.IO;
using Firebase.Database;

namespace Finalv67
{
    public static class ConfiguracionFirebase
    {
        // Los datos de configuración
        public const string BasePath = "https://pasteleria-dlola-default-rtdb.firebaseio.com/";
        public const string ApiKey = "AIzaSyD9zTBs6G4ERCMtrPIEPuz3-IfwfjivbOQ";
        public const string AuthDomain = "pasteleria-dlola.firebaseapp.com";
    }

    public class ConexionFirebase
    {
        // Esta variable guardará el token de forma global
        public static string TokenGlobal = null;

        public static FirebaseClient Conectar(string token = null)
        {
            // Si no pasamos nada, usamos el TokenGlobal guardado
            string tokenFinal = token ?? TokenGlobal;

            if (string.IsNullOrEmpty(tokenFinal))
            {
                return new FirebaseClient(ConfiguracionFirebase.BasePath);
            }
            else
            {
                return new FirebaseClient(
                    ConfiguracionFirebase.BasePath,
                    new FirebaseOptions
                    {
                        AuthTokenAsyncFactory = () => Task.FromResult(tokenFinal)
                    }
                );
            }
        }
    }
}