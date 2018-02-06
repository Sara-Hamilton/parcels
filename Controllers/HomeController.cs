using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {

  [Route("/shipping")]
  public ActionResult ShippingCalc()
  {
    return View("ShippingCalc");
  }

  [Route("/goodbye")]
  public string Goodbye() { return "Goodbye friend."; }

  [Route("/shipping_total")]
  public ActionResult ShippingTotal()
  {
    Parcel newParcel = new Parcel();
    newParcel.SetHeight(int.Parse(Request.Query["height"]));
    newParcel.SetDepth(int.Parse(Request.Query["depth"]));
    newParcel.SetWidth(int.Parse(Request.Query["width"]));
    newParcel.SetWeight(int.Parse(Request.Query["weight"]));
    int total = newParcel.CostToShip(newParcel.GetHeight(), newParcel.GetDepth(), newParcel.GetWidth(), newParcel.GetWeight());
    newParcel.SetTotal(total);
    return View("ShippingTotal", newParcel);

    // int height = int.Parse(Request.Query["height"]);
    // newParcel.SetHeight(height);
    // int depth = int.Parse(Request.Query["depth"]);
    // newParcel.SetDepth(depth);
    // int width = int.Parse(Request.Query["width"]);
    // newParcel.SetWidth(width);
    // int weight = int.Parse(Request.Query["weight"]);
    // newParcel.SetWeight(weight);
    // int total = newParcel.CostToShip(height, depth, width, weight);
    // newParcel.SetTotal(total);
    // return View("ShippingTotal", newParcel);
  }

  }
}
