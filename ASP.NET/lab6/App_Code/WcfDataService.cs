using System;
using System.Data.Services;
using System.Data.Services.Common;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;

public class WcfDataService : DataService<NORTHWNDModel.NORTHWNDEntities>
{
    // Этот метод вызывается только один раз для инициализации серверных политик.
    public static void InitializeService(DataServiceConfiguration config)
    {
        // TODO: задайте правила, чтобы указать, какие наборы сущностей и служебные операции являются видимыми, обновляемыми и т.д.
        // Примеры:
         config.SetEntitySetAccessRule("*", EntitySetRights.AllRead);
        // config.SetServiceOperationAccessRule("СлужебнаяОперация", ServiceOperationRights.All);
        config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
    }
}
