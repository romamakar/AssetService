using AssetService.Domain.Models.Asset;
using AssetService.Domain.Services;
using AssetService.WebApi.DTO.Asset;
using Microsoft.AspNetCore.Mvc;

namespace AssetService.WebApi.Controllers
{
    [Route("api/assets")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        private readonly IAssetService _assetService;
        public AssetsController(IAssetService assetService)
        {
            _assetService = assetService;
        }
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetAssetResultDto), 200)]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _assetService.Get(new GetAssetCommand
            {
                 Id = id
            });
            return Ok(new GetAssetResultDto
            {
                AssetId = result.Id,
                AssetNr = result.AssetNr,
                Id = result.Id,
                ClientId = result.ClientId,
                DimX = result.DimX,
                DimY = result.DimY,
                Type = result.Type,
                LastCreatedDate = result.LastCreatedDate,
                LastUpdatedDate = result.LastUpdatedDate
            });
        }


        [HttpPost]
        [ProducesResponseType(typeof(CreateAssetResultDto), 201)]
        public async Task<IActionResult> Post([FromBody] CreateAssetDto dto)
        {
            var result = await _assetService.Create(new CreateAssetCommand
            {
                AssetId = dto.AssetId,
                AssetNr = dto.AssetNr,
                ClientId = dto.ClientId,
                DimX = dto.DimX,
                DimY = dto.DimY,
                Type = dto.Type,
                LastCreatedDate = dto.LastCreatedDate,
                LastUpdatedDate = dto.LastUpdatedDate
            });
            return Created("", new CreateAssetResultDto { Id = result.Id});
        }


        [HttpPut("{id}")]
        [ProducesResponseType(typeof(EditAssetResultDto), 200)]
        public async Task<IActionResult> Put(int id, [FromBody] EditAssetDto dto)
        {
            var result = await _assetService.Edit(new EditAssetCommand
            {

            });
            return Ok(new EditAssetResultDto());
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(DeleteAssetResultDto), 200)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _assetService.Delete(new DeleteAssetCommand
            {

            });
            return Ok(new DeleteAssetResultDto());
        }
    }
}
