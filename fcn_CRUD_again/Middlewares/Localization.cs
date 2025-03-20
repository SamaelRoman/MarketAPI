namespace fcn_CRUD_again.Middlewares
{
    public class Localization
    {
        private readonly RequestDelegate next;

        public Localization(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            
        }
    }
}
