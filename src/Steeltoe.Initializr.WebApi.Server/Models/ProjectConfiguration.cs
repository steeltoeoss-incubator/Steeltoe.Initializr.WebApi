namespace Steeltoe.Initializr.WebApi.Server.Models
{
	/// <summary>
	/// A model ofi the configuration used to generate a project.
	/// </summary>
	public class ProjectConfiguration
	{
		/// <summary>
		/// Compares the specified object to this object.
		/// </summary>
		/// <param name="obj">other instance</param>
		/// <returns>whether objects are equal</returns>
		public override bool Equals(object obj)
		{
			return true;
		}

		/// <summary>
		/// Returns the hash code for this object.
		/// </summary>
		/// <returns>object hash code</returns>
		public override int GetHashCode()
		{
			return 0;
		}
	}
}
