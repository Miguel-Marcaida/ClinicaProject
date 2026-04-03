using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Entidades;
using Datos.Repositorios;

namespace Negocio.Servicios
{
    public class FormularioService
    {
        private FormularioRepositorio _formularioRepositorio = new FormularioRepositorio();

        public List<Formulario> ListarFormularios()
        {
            try
            {
                return _formularioRepositorio.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el servicio al listar formularios: " + ex.Message);
            }
        }

        public void GuardarFormulario(Formulario formulario)
        {
            try
            {
                // --- VALIDACIONES DE NEGOCIO ---

                // A. Campos obligatorios
                if (string.IsNullOrWhiteSpace(formulario.nombre_control))
                    throw new Exception("El nombre del control técnico es obligatorio.");

                if (string.IsNullOrWhiteSpace(formulario.etiqueta))
                    throw new Exception("La etiqueta para el usuario es obligatoria.");

                // B. Sin espacios en el nombre del control (porque es un Name de C#)
                if (formulario.nombre_control.Contains(" "))
                    throw new Exception("El nombre del control no puede contener espacios (Ej: btnPacientes).");

                // C. Validar duplicados en la DB
                if (_formularioRepositorio.ExisteNombre(formulario.nombre_control, formulario.id_formulario))
                    throw new Exception("Ya existe un formulario registrado con ese nombre de control.");

                // --- PERSISTENCIA ---
                if (formulario.id_formulario == 0)
                {
                    _formularioRepositorio.Agregar(formulario);
                }
                else
                {
                    _formularioRepositorio.Editar(formulario);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el servicio al guardar formulario: " + ex.Message);
            }

        }


        public void EliminarFormulario(int idFormulario)
        {
            try
            {
                // Aquí podrías validar si el formulario está siendo usado por algún rol antes de eliminarlo
                _formularioRepositorio.EliminarLogico(idFormulario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el servicio al eliminar formulario: " + ex.Message);
            }


        }
    }
}
