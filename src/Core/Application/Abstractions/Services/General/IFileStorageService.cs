using DN.WebApi.Domain.Enums;
using DN.WebApi.Shared.DTOs.Storage;

namespace DN.WebApi.Application.Abstractions.Services.General;

public interface IFileStorageService : ITransientService
{
    public Task<string> UploadAsync<T>(FileUploadRequest request, FileType supportedFileType)
    where T : class;
}