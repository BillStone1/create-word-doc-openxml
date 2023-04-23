using Microsoft.OpenApi.Models;

namespace Swashbuckle.AspNetCore.Swagger
{
    internal class Info : OpenApiInfo
    {
        private string version;
        private string title;

        public new string Title { get => title; set => title = value; }
        public new string Version { get => version; set => version = value; }
    }
}