using CommandSystem;
using Exiled.API.Features;
using PlayerRoles;
using System;


namespace RulesCommand
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class Command : ICommand
    {
        string ICommand.Command { get; } = "Rules";
        public string[] Aliases { get; } = new string[] { "RL" };
        public string Description { get; } = "Using this command you can see the rulebook of your class";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player player = Player.Get(sender);
            if (player != null)
            {
                switch (player.Role.Type)
                {
                    case RoleTypeId.ClassD:
                        response = Plugin.Instance.Translation.ClassDRules;
                        break;
                    case RoleTypeId.Scientist:
                        response = Plugin.Instance.Translation.ScientistRules;
                        break;
                    case RoleTypeId.FacilityGuard:
                        response = Plugin.Instance.Translation.GuardRules;
                        break;
                    case RoleTypeId.Scp049:
                    case RoleTypeId.Scp173:
                    case RoleTypeId.Scp106:
                    case RoleTypeId.Scp096:
                    case RoleTypeId.Scp939:
                    case RoleTypeId.Scp3114:
                    case RoleTypeId.Scp079:
                    case RoleTypeId.Scp0492:
                        response = Plugin.Instance.Translation.SCPrules;
                        break;
                    case RoleTypeId.NtfPrivate:
                    case RoleTypeId.NtfSergeant:
                    case RoleTypeId.NtfSpecialist:
                    case RoleTypeId.NtfCaptain:
                        response = Plugin.Instance.Translation.MTFRules;
                        break;
                    case RoleTypeId.ChaosRifleman:
                    case RoleTypeId.ChaosMarauder:
                    case RoleTypeId.ChaosConscript:
                    case RoleTypeId.ChaosRepressor:
                        response = Plugin.Instance.Translation.ChaosRules;
                        break;
                    default:
                        response = "No rules for designated role";
                        return false;
                }
                return true;
            }
            else
            {
                response = "null";
                return false;
            }
        }
    }
}
