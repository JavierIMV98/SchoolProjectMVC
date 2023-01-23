namespace SchoolProjectMVC.Models;
//como que maneja la data, generalmente suelen ser las cosas dinamicas. Para cada cosa se crea una clase.
//Por ejemplo en el controlador se pasa la informacion que esta en esta clase para mostrar.
public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
