using System;
namespace CORE.Componentes.Personalizados.Timeline.Enums
{
    [Flags]
    public enum KendoGridMode
    {
        Insert = 1,
        Edit = 2,
        Delete = 4,
        None = 8,
    }
}
