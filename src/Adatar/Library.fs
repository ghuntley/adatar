namespace Adatar

#if INTERACTIVE
#r @"../../packages/StatsdClient/lib/net35/StatsdClient.dll";;
#endif
open StatsdClient

/// Documentation for my library
///
/// ## Example
///
///     let h = Library.hello 1
///     printfn "%d" h
///
module Library = 
  
  Metrics.Counter("stat-name")
  ///
  /// Returns 42
  /// ## Parameters
  ///  - `num` - whatever
  let hello num = 42