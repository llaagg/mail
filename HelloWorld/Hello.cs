using System;
using System.Collections.Generic;
using Revuo.Home.Abstractions;

namespace HelloWorld
{
    public class Hello : ILogic, IInfo
    {        
        private string? WindowId = null;

        public async Task<IResult> Do(IContext context)
        {
            var result =
                        context.Run("Revuo.Home.Components.UI.Box",
                            new Request(
                                WindowId, 
                                "Hello",
                                "World"
                                ))
                            .Result;
            return new Result();
        }

        public List<KeyValuePair<string, string>> GetInfo()
        {
            return new List<KeyValuePair<string, string>>(){
                new KeyValuePair<string, string>(MetaData.StartAble,"true")
            };
        }
    }
}
