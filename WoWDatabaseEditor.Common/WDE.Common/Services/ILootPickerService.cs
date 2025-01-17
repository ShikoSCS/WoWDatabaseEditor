using System.Threading.Tasks;
using WDE.Common.Database;
using WDE.Module.Attributes;

namespace WDE.Common.Services;

[UniqueProvider]
public interface ILootPickerService
{
    Task<uint?> PickLoot(LootSourceType lootType);
}