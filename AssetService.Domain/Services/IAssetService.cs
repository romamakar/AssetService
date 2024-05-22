using AssetService.Domain.Models.Asset;

namespace AssetService.Domain.Services
{
    public interface IAssetService
    {
        Task<GetAssetResult> Get(GetAssetCommand command);
        Task<CreateAssetResult> Create(CreateAssetCommand command);
        Task<EditAssetResult> Edit(EditAssetCommand command);
        Task<DeleteAssetResult> Delete(DeleteAssetCommand command);
    }
}
