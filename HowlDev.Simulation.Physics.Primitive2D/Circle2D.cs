namespace HowlDev.Simulation.Physics.Primitive2D;

/// <summary>
/// Given a point and radius, provides methods to determine overlap with other 
/// Circle objects and if points are within them. (This is likely to expand in 
/// the future).
/// </summary>
public class Circle2D : IEquatable<Circle2D>, IComparable<Circle2D> {
    private Point2D center;
    private double radius;

    #region Properties
    public Point2D Center {
        get { return center; } 
        set {
            center = value;
        }
    }
    #endregion
    #region Constructors
    public Circle2D() {
        center = new();
        radius = 0;
    }
    #endregion
    #region Methods

    #endregion
    #region Operators

    #endregion
    #region Custom Operators

    #endregion
    #region Default Overrides
    /// <summary>
    /// <include file="_SharedXML.xml" path='doc/member[@name="Phrases.Implementation.Equatable"]/*'/>
    /// </summary>
    public bool Equals(Circle2D? other) {
        if (other is null) return false;
        return center == other.center && radius == other.radius;
    }

    /// <summary>
    /// IComparable interface implementation. Checks the point first, then compares the radius.
    /// </summary>
    /// <returns><include file="_SharedXML.xml" path='doc/member[@name="Phrases.Compare.Return"]/*'/></returns>
    public int CompareTo(Circle2D? other) {
        if (other is null) return 1;
        int point = center.CompareTo(other.center);
        if (point == 0) {
            return radius.CompareTo(other.radius);
        }
        return point;
    }

    /// <summary>
    /// <include file="_SharedXML.xml" path='doc/member[@name="Phrases.Overriden.Equals"]/*'/> <see cref="Equals(Circle2D?)"/>.
    /// </summary>
    public override bool Equals(object? obj) {
        return base.Equals(obj);
    }

    /// <summary>
    /// Gets the hash code of the Angle inside this class.
    /// </summary>
    public override int GetHashCode() {
        return HashCode.Combine(radius.GetHashCode(), center.GetHashCode());
    }

    /// <summary>
    /// <include file="_SharedXML.xml" path='doc/member[@name="Phrases.Overriden.ToString"]/*'/> "Angle: {rotationAngle}".
    /// </summary>
    public override string ToString() {
        return $"Center: {center}, Radius: {radius}";
    }
    #endregion
}