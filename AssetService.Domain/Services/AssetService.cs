using AssetService.Domain.Models.Asset;
using AssetService.Persistence;
using AssetService.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace AssetService.Domain.Services
{
    public class AssetService : IAssetService
    {
        AssetDbContext _context;
        public AssetService(AssetDbContext context)
        {
            _context = context;
        }
        public async Task<CreateAssetResult> Create(CreateAssetCommand command)
        {
            var entity = new AssetEntity
            {
                AssetId = command.AssetId,
                AssetNr = command.AssetNr,
                ClientId = command.ClientId,
                DimX = command.DimX,
                DimY = command.DimY,
                Type = command.Type,
                LastCreatedDate = command.LastCreatedDate,
                LastUpdatedDate = command.LastUpdatedDate
            };

            _context.Assets.Add(entity);
            await _context.SaveChangesAsync();

            return new CreateAssetResult { Id = entity.Id };

        }

        public Task<DeleteAssetResult> Delete(DeleteAssetCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<EditAssetResult> Edit(EditAssetCommand command)
        {
            throw new NotImplementedException();
        }

        public async Task<GetAssetResult> Get(GetAssetCommand command)
        {
            var asset = await _context.Assets.FirstAsync(x => x.Id == command.Id);
            return new GetAssetResult
            {
                AssetId = asset.AssetId,
                AssetNr = asset.AssetNr,
                Id = asset.Id,
                ClientId = asset.ClientId,
                DimX = asset.DimX,
                DimY = asset.DimY,
                Type = asset.Type,
                LastCreatedDate = asset.LastCreatedDate,
                LastUpdatedDate = asset.LastUpdatedDate
            };
        }
    }
}
