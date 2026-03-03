namespace PersonsApp.Dtos.Common
{
    public class ResponseDto<T> // la letra T indica que puede ser cualquier tipo de dato
    {
        public int StatusCode { get; set; } // Código de respuesta
        public string Message { get; set; } //Mensaje de la respuesta 
        public bool Status { get; set; } // Verdadero para respuestas correctas, sin errores y si no falso
        public T Data { get; set; } //Este valor es dinámico
    }
}