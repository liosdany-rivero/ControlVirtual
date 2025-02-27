namespace ControlVirtual.Vistas.Gestion
{
    class Validacion
    {
        // Control Codigo (enteros, sin nulos)
        public static bool ValidarControlCodigo(Control control, ErrorProvider eProvider, int Codigo)
        {
            string mensaje = "Debe introducirse un número entero positivo.";

            if (!int.TryParse(control.Text, out int id))
            {
                MostrarError(control, eProvider, mensaje);
                return false;
            }
            else if (id < Codigo)
            {
                MostrarError(control, eProvider, mensaje);
                return false;
            }
            else
            {
                LimpiarError(control, eProvider);
            }
            return true;
        }

        // Control Nombre (texto, sin nulos)
        public static bool ValidarControlNombre(Control control, ErrorProvider eProvider)
        {
            string mensaje = "Debe introducirse una cadena de texto alfanumérica.";

            if (string.IsNullOrWhiteSpace(control.Text))
            {
                MostrarError(control, eProvider, mensaje);
                return false;
            }
            else
            {
                LimpiarError(control, eProvider);
            }
            return true;
        }

        // Control Numero (double, sin nulos opcional)
        public static bool ValidarControlNumero(Control control, ErrorProvider eProvider, bool permitirCero = false)
        {
            string mensaje = "Debe introducirse un número.";

            if (!double.TryParse(control.Text, out double numero))
            {
                MostrarError(control, eProvider, mensaje);
                return false;
            }
            else if (numero < 0)
            {
                MostrarError(control, eProvider, mensaje);
                return false;
            }
            else if (permitirCero == false)
            {
                if (numero == 0)
                {
                    MostrarError(control, eProvider, mensaje);
                    return false;
                }
                else
                {
                    LimpiarError(control, eProvider);
                    return true;
                }
            }
            else
            {
                LimpiarError(control, eProvider);
                return true;
            }
        }

        //TODO: Implementar la validacion de fecha y de contraseña

        //// Validar fecha válida
        //public static bool ValidarFecha(Control control, string mensajeError = "Fecha inválida")
        //{
        //    if (!DateTime.TryParse(control.Text, out _))
        //    {
        //        MostrarError(control, mensajeError);
        //        return false;
        //    }
        //    return true;
        //}

        //// Validar coincidencia entre dos controles (ej: contraseñas)
        //public static bool ValidarIgualdad(Control control1, Control control2,
        //                                 string mensajeError = "Los valores no coinciden")
        //{
        //    if (control1.Text != control2.Text)
        //    {
        //        MostrarError(control2, mensajeError);
        //        return false;
        //    }
        //    return true;
        //}


        // Método para mostrar errores
        private static void MostrarError(Control control, ErrorProvider eProvider, string MensajeError)
        {
            eProvider.SetError(control, MensajeError);
            control.Focus();
        }

        // Limpiar errores de validación
        public static void LimpiarError(Control control, ErrorProvider eProvider)
        {
            eProvider.SetError(control, "");
        }

        // Limpiar errores de validación
        public static void LimpiarTodosErrores(Form form, ErrorProvider eProvider)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    eProvider.SetError(control, "");
                }
            }
        }

    }
}

