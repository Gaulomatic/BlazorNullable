using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorNullable.Components
{
	public class NestedComponent : ComponentBase
	{
		[Parameter] public RenderFragment ChildContent { get; set; }

		/// <inheritdoc />
		protected override void BuildRenderTree(RenderTreeBuilder builder)
		{
			builder.AddContent(0, this.ChildContent);
		}
	}
}
