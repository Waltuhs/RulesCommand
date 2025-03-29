using System.ComponentModel;

namespace RulesCommand
{
    public class Translations : ITranslation
    {
        [Description("Rules for Class-D")]
        public string ClassDRules { get; set; } = "Class-D rules: \n 1) Escape the facility.";

        [Description("Rules for Scientist")]
        public string ScientistRules { get; set; } = "Scientist rules: \n 1) Avoid SCPs \n 2) Work with MTF to escape";

        [Description("Rules for Guard")]
        public string GuardRules { get; set; } = "Guard rules: \n 1) Arrest Class-D \n 2) Terminate all SCPs \n 3) Defeat Chaos";

        [Description("Rules for SCPs")]
        public string SCPrules { get; set; } = "SCP rules: \n 1) Kill all Personnel";

        [Description("Rules for MTF")]
        public string MTFRules { get; set; } = "MTF rules: \n 1) Terminate all SCPs \n 2) Arrest Class-D \n 3) Defeat Chaos";

        [Description("Rules for Chaos Insurgency")]
        public string ChaosRules { get; set; } = "Chaos rules: \n Free the Class-D \n 2) Fight against the MTF and SCPs";
    }
}
