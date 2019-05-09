using Basic.Lib;
using Files.Model;
using System;

namespace Files.IService
{
    public interface IDomainService
    {
        ReturnResult<ReturnOpenModel> OpenDomain(OpenModel model);

        long ValidSize(string id);

        int ModifyDomain(string id, DomainModel model);
    }
}
