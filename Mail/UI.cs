using System;
using System.Collections.Generic;
using Revuo.Home.Abstractions;

namespace Mail
{
    public class UI : ILogic, IInfo
    {        
        private string? WindowId = null;

        public async Task<IResult> Do(IContext context)
        {
            var result =
                        context.Run("Revuo.Home.Components.UI.Control",
                            new Request(
                                WindowId, 
                                new
                                {
                                    Title = "Mail",
                                    TypeName = typeof(MailControl).AssemblyQualifiedName
                                },
                                DateTime.Now.ToString()
                                ))
                            .Result;

                    if (result.Success)
                    {
                        WindowId = result.Data<string>(0);
                    }
            return new Result();
        }

        public List<KeyValuePair<string, string>> GetInfo()
        {
            return new List<KeyValuePair<string, string>>(){
                new KeyValuePair<string, string>(MetaData.StartAble,"true"),
                new KeyValuePair<string, string>(MetaData.Label,"Mail"),
                new KeyValuePair<string, string>(MetaData.UTFSymbol,"✉"),
            };
        }
    }
}
