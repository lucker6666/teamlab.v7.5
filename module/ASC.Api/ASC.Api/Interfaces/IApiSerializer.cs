/* 
 * 
 * (c) Copyright Ascensio System Limited 2010-2014
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * http://www.gnu.org/licenses/agpl.html 
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;

namespace ASC.Api.Interfaces
{
    public interface IApiSerializer
    {
        IEnumerable<string> GetSupportedExtensions();
        bool CanSerializeType(Type type);
        bool CanRespondTo(IApiStandartResponce responce, string path, string contentType);
        ContentType RespondTo(IApiStandartResponce responce, TextWriter output, string path, string contentType, bool pretty, bool async);
    }
}