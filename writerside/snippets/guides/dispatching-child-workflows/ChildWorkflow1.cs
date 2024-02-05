using Elsa.Workflows;
using Elsa.Workflows.Activities;
using Elsa.Workflows.Contracts;
using JetBrains.Annotations;

namespace ElsaServer.Workflows;

[UsedImplicitly]
public class ChildWorkflow : WorkflowBase
{
    protected override void Build(IWorkflowBuilder builder)
    {
        builder.Name = "Child Workflow";
        builder.Root = new WriteLine("Hello from Child");
    }
}