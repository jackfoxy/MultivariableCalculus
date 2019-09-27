namespace MultivariableCalculus

open MathNet.Numerics
open System.Numerics

module Library = 
  
  /// Returns 42
  ///
  /// ## Parameters
  ///  - `num` - whatever
  let hello _ = 42


  let v2D = LinearAlgebra.Vector<double>.Build.Dense(2)
  let v3D = LinearAlgebra.Vector<double>.Build.Dense(3)

  let vector2 = System.Numerics.Vector2(1.f, 1.f)
  let vector3 = System.Numerics.Vector3(1.f, 1.f, 1.f)