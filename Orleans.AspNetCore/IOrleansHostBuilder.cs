namespace Orleans.AspNetCore
{
    public interface IOrleansHostBuilder
    {
        IOrleansHost Build();

        IOrleansHostBuilder UseStartup<TStartup>() where TStartup : class;
    }
}