// Reference: Facepunch.ID
// Reference: Google.ProtocolBuffers

using System.Collections.Generic;
using System.Linq;

namespace Oxide.Plugins
{
    [Info("Hooks Test", "Oxide Team", 0.1)]
    public class HooksTest : RustLegacyPlugin
    {
        int hookCount = 0;
        int hooksVerified;
        Dictionary<string, bool> hooksRemaining = new Dictionary<string, bool>();

        public void HookCalled(string name)
        {
            if (!hooksRemaining.ContainsKey(name)) return;
            hookCount--;
            hooksVerified++;
            PrintWarning("{0} is working. {1} hooks verified!", name, hooksVerified);
            hooksRemaining.Remove(name);
            if (hookCount == 0)
                PrintWarning("All hooks verified!");
            else
                PrintWarning("{0} hooks remaining: " + string.Join(", ", hooksRemaining.Keys.ToArray()), hookCount);
        }

        private void InitLogging()
        {
            HookCalled("InitLogging");
        }

        private void Init()
        {
            hookCount = hooks.Count;
            hooksRemaining = hooks.Keys.ToDictionary(k => k, k => true);
            PrintWarning("{0} hook to test!", hookCount);
            HookCalled("Init");
        }

        public void Loaded()
        {
            HookCalled("Loaded");
        }

        protected override void LoadDefaultConfig()
        {
            HookCalled("LoadDefaultConfig");
        }

        private void Unloaded()
        {
            HookCalled("Unloaded");
        }

        private void OnFrame()
        {
            HookCalled("OnFrame");
        }

        private void ModifyTags(string oldtags)
        {
            HookCalled("ModifyTags");
            // TODO: Modify tags, either remove or add
        }

        private void BuildServerTags(IList<string> tags)
        {
            HookCalled("BuildServerTags");
            // TODO: Print new tags
        }

        private void OnServerInitialized()
        {
            HookCalled("OnServerInitialized");
        }

        private void OnServerSave()
        {
            HookCalled("OnServerSave");
        }

        private void OnServerShutdown()
        {
            HookCalled("OnServerShutdown");
        }

        private void OnRunCommand(ConsoleSystem.Arg arg)
        {
            HookCalled("OnRunCommand");
            // TODO: Run test command
            // TODO: Print command messages
        }

        private void OnUserApprove(ClientConnection connection, uLink.NetworkPlayerApproval approval, ConnectionAcceptor acceptor)
        {
            HookCalled("OnUserApprove");
        }

        private void CanClientLogin(ClientConnection connection)
        {
            HookCalled("CanClientLogin");
        }

        private void OnPlayerConnected(NetUser netuser)
        {
            HookCalled("OnPlayerConnected");
            // TODO: Print player connected
        }

        private void OnPlayerDisconnected(uLink.NetworkPlayer player)
        {
            HookCalled("OnPlayerDisconnected");
            // TODO: Print player disconnected
        }

        private void OnPlayerSpawn(PlayerClient client, bool useCamp, RustProto.Avatar avater)
        {
            HookCalled("OnPlayerSpawn");
            // TODO: Print spawn location
            // TODO: Print start metabolism values
            // TODO: Give admin items for testing
        }

        private void OnItemCraft(CraftingInventory inventory, BlueprintDataBlock blueprint, int amount, ulong startTime)
        {
            HookCalled("OnItemCraft");
            // TODO: Print item crafting
        }

        private void OnItemDeployed(DeployableObject component, NetUser user)
        {
            HookCalled("OnItemDeployed");
            // TODO: Print item deployed
        }

        private void OnItemAdded(Inventory inventory, int slot, IInventoryItem item)
        {
            HookCalled("OnItemAdded");
            // TODO: Print item added
        }

        private void OnItemRemoved(Inventory inventory, int slot, IInventoryItem item)
        {
            HookCalled("OnItemRemoved");
            // TODO: Print item removed
        }

        private void OnDoorToggle(BasicDoor door, ulong timestamp, Controllable Controllable)
        {
            HookCalled("OnDoorToggle");
        }

        private void ModifyDamage(TakeDamage takedamage, DamageEvent damage)
        {
            HookCalled("ModifyDamage");
        }

        private void OnHurt(TakeDamage takedamage, DamageEvent damage)
        {
            HookCalled("OnHurt");
        }

        private void OnKilled(TakeDamage takedamage, DamageEvent damage)
        {
            HookCalled("OnKilled");
        }

        private void OnStructureBuilt(StructureComponent component, NetUser user)
        {
            HookCalled("OnStructureBuilt");
        }

        private void OnPlayerChat(NetUser user, string message)
        {
            HookCalled("OnPlayerChat");
        }

        private void OnPlayerVoice(NetUser user, List<uLink.NetworkPlayer> listeners)
        {
            HookCalled("OnPlayerVoice");
        }

        private void OnAirDrop()
        {
            HookCalled("OnAirDrop");
            // TODO: Complete parameters
        }

        private void OnStructureDecay()
        {
            HookCalled("OnStructureDecay");
            // TODO: Complete parameters
        }

        private void OnResearchItem()
        {
            HookCalled("OnResearchItem");
            // TODO: Complete parameters
        }

        private void OnBlueprintUse()
        {
            HookCalled("OnBlueprintUse");
            // TODO: Complete parameters
        }

        private void OnDatablocksInitialized()
        {
            HookCalled("OnDatablocksInitialized");
            // TODO: Complete parameters
        }

        private void OnResourceNodeLoaded()
        {
            HookCalled("OnResourceNodeLoaded");
            // TODO: Complete parameters
        }
    }
}
