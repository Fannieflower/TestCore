using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.imp.otd.otdapi.service{
	
	
	
	public class VopReportModelHelper : TBeanSerializer<VopReportModel>
	{
		
		public static VopReportModelHelper OBJ = new VopReportModelHelper();
		
		public static VopReportModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(VopReportModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("date".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDate(value);
					}
					
					
					
					
					
					if ("channel".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.imp.otd.otdapi.service.VopDeliveryChannelType? value;
						
						value = com.vip.imp.otd.otdapi.service.VopDeliveryChannelTypeUtil.FindByName(iprot.ReadString());
						
						structs.SetChannel(value);
					}
					
					
					
					
					
					if ("campaign_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCampaign_id(value);
					}
					
					
					
					
					
					if ("campaign_title".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCampaign_title(value);
					}
					
					
					
					
					
					if ("ad_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAd_id(value);
					}
					
					
					
					
					
					if ("ad_title".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAd_title(value);
					}
					
					
					
					
					
					if ("placement_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPlacement_id(value);
					}
					
					
					
					
					
					if ("placement_title".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPlacement_title(value);
					}
					
					
					
					
					
					if ("impression".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetImpression(value);
					}
					
					
					
					
					
					if ("click".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetClick(value);
					}
					
					
					
					
					
					if ("cost".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetCost(value);
					}
					
					
					
					
					
					if ("click_rate".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetClick_rate(value);
					}
					
					
					
					
					
					if ("cost_per_click".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetCost_per_click(value);
					}
					
					
					
					
					
					if ("cost_per_mille".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetCost_per_mille(value);
					}
					
					
					
					
					
					if ("app_waken_uv".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetApp_waken_uv(value);
					}
					
					
					
					
					
					if ("cost_per_app_waken_uv".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetCost_per_app_waken_uv(value);
					}
					
					
					
					
					
					if ("app_waken_pv".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetApp_waken_pv(value);
					}
					
					
					
					
					
					if ("app_waken_rate".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetApp_waken_rate(value);
					}
					
					
					
					
					
					if ("miniapp_uv".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetMiniapp_uv(value);
					}
					
					
					
					
					
					if ("app_uv".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetApp_uv(value);
					}
					
					
					
					
					
					if ("cost_per_app_uv".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetCost_per_app_uv(value);
					}
					
					
					
					
					
					if ("cost_per_miniapp_uv".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetCost_per_miniapp_uv(value);
					}
					
					
					
					
					
					if ("general_uv".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetGeneral_uv(value);
					}
					
					
					
					
					
					if ("product_uv".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetProduct_uv(value);
					}
					
					
					
					
					
					if ("special_uv".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetSpecial_uv(value);
					}
					
					
					
					
					
					if ("book_customer_in_24hour".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetBook_customer_in_24hour(value);
					}
					
					
					
					
					
					if ("new_customer_in_24hour".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetNew_customer_in_24hour(value);
					}
					
					
					
					
					
					if ("customer_in_24hour".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetCustomer_in_24hour(value);
					}
					
					
					
					
					
					if ("book_sales_in_24hour".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetBook_sales_in_24hour(value);
					}
					
					
					
					
					
					if ("sales_in_24hour".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetSales_in_24hour(value);
					}
					
					
					
					
					
					if ("book_orders_in_24hour".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetBook_orders_in_24hour(value);
					}
					
					
					
					
					
					if ("orders_in_24hour".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetOrders_in_24hour(value);
					}
					
					
					
					
					
					if ("book_roi_in_24hour".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetBook_roi_in_24hour(value);
					}
					
					
					
					
					
					if ("roi_in_24hour".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetRoi_in_24hour(value);
					}
					
					
					
					
					
					if ("book_customer_in_14day".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetBook_customer_in_14day(value);
					}
					
					
					
					
					
					if ("new_customer_in_14day".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetNew_customer_in_14day(value);
					}
					
					
					
					
					
					if ("customer_in_14day".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetCustomer_in_14day(value);
					}
					
					
					
					
					
					if ("book_sales_in_14day".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetBook_sales_in_14day(value);
					}
					
					
					
					
					
					if ("sales_in_14day".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetSales_in_14day(value);
					}
					
					
					
					
					
					if ("book_orders_in_14day".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetBook_orders_in_14day(value);
					}
					
					
					
					
					
					if ("orders_in_14day".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetOrders_in_14day(value);
					}
					
					
					
					
					
					if ("book_roi_in_14day".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetBook_roi_in_14day(value);
					}
					
					
					
					
					
					if ("roi_in_14day".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetRoi_in_14day(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(VopReportModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetDate() != null) {
				
				oprot.WriteFieldBegin("date");
				oprot.WriteString(structs.GetDate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetChannel() != null) {
				
				oprot.WriteFieldBegin("channel");
				oprot.WriteString(structs.GetChannel().ToString());  
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCampaign_id() != null) {
				
				oprot.WriteFieldBegin("campaign_id");
				oprot.WriteString(structs.GetCampaign_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCampaign_title() != null) {
				
				oprot.WriteFieldBegin("campaign_title");
				oprot.WriteString(structs.GetCampaign_title());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAd_id() != null) {
				
				oprot.WriteFieldBegin("ad_id");
				oprot.WriteString(structs.GetAd_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAd_title() != null) {
				
				oprot.WriteFieldBegin("ad_title");
				oprot.WriteString(structs.GetAd_title());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPlacement_id() != null) {
				
				oprot.WriteFieldBegin("placement_id");
				oprot.WriteString(structs.GetPlacement_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPlacement_title() != null) {
				
				oprot.WriteFieldBegin("placement_title");
				oprot.WriteString(structs.GetPlacement_title());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetImpression() != null) {
				
				oprot.WriteFieldBegin("impression");
				oprot.WriteI64((long)structs.GetImpression()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("impression can not be null!");
			}
			
			
			if(structs.GetClick() != null) {
				
				oprot.WriteFieldBegin("click");
				oprot.WriteI64((long)structs.GetClick()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("click can not be null!");
			}
			
			
			if(structs.GetCost() != null) {
				
				oprot.WriteFieldBegin("cost");
				oprot.WriteI64((long)structs.GetCost()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cost can not be null!");
			}
			
			
			if(structs.GetClick_rate() != null) {
				
				oprot.WriteFieldBegin("click_rate");
				oprot.WriteDouble((double)structs.GetClick_rate());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("click_rate can not be null!");
			}
			
			
			if(structs.GetCost_per_click() != null) {
				
				oprot.WriteFieldBegin("cost_per_click");
				oprot.WriteI64((long)structs.GetCost_per_click()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cost_per_click can not be null!");
			}
			
			
			if(structs.GetCost_per_mille() != null) {
				
				oprot.WriteFieldBegin("cost_per_mille");
				oprot.WriteI64((long)structs.GetCost_per_mille()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cost_per_mille can not be null!");
			}
			
			
			if(structs.GetApp_waken_uv() != null) {
				
				oprot.WriteFieldBegin("app_waken_uv");
				oprot.WriteI64((long)structs.GetApp_waken_uv()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("app_waken_uv can not be null!");
			}
			
			
			if(structs.GetCost_per_app_waken_uv() != null) {
				
				oprot.WriteFieldBegin("cost_per_app_waken_uv");
				oprot.WriteI64((long)structs.GetCost_per_app_waken_uv()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cost_per_app_waken_uv can not be null!");
			}
			
			
			if(structs.GetApp_waken_pv() != null) {
				
				oprot.WriteFieldBegin("app_waken_pv");
				oprot.WriteI64((long)structs.GetApp_waken_pv()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("app_waken_pv can not be null!");
			}
			
			
			if(structs.GetApp_waken_rate() != null) {
				
				oprot.WriteFieldBegin("app_waken_rate");
				oprot.WriteDouble((double)structs.GetApp_waken_rate());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("app_waken_rate can not be null!");
			}
			
			
			if(structs.GetMiniapp_uv() != null) {
				
				oprot.WriteFieldBegin("miniapp_uv");
				oprot.WriteI64((long)structs.GetMiniapp_uv()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("miniapp_uv can not be null!");
			}
			
			
			if(structs.GetApp_uv() != null) {
				
				oprot.WriteFieldBegin("app_uv");
				oprot.WriteI64((long)structs.GetApp_uv()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("app_uv can not be null!");
			}
			
			
			if(structs.GetCost_per_app_uv() != null) {
				
				oprot.WriteFieldBegin("cost_per_app_uv");
				oprot.WriteI64((long)structs.GetCost_per_app_uv()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cost_per_app_uv can not be null!");
			}
			
			
			if(structs.GetCost_per_miniapp_uv() != null) {
				
				oprot.WriteFieldBegin("cost_per_miniapp_uv");
				oprot.WriteI64((long)structs.GetCost_per_miniapp_uv()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cost_per_miniapp_uv can not be null!");
			}
			
			
			if(structs.GetGeneral_uv() != null) {
				
				oprot.WriteFieldBegin("general_uv");
				oprot.WriteI64((long)structs.GetGeneral_uv()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("general_uv can not be null!");
			}
			
			
			if(structs.GetProduct_uv() != null) {
				
				oprot.WriteFieldBegin("product_uv");
				oprot.WriteI64((long)structs.GetProduct_uv()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("product_uv can not be null!");
			}
			
			
			if(structs.GetSpecial_uv() != null) {
				
				oprot.WriteFieldBegin("special_uv");
				oprot.WriteI64((long)structs.GetSpecial_uv()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("special_uv can not be null!");
			}
			
			
			if(structs.GetBook_customer_in_24hour() != null) {
				
				oprot.WriteFieldBegin("book_customer_in_24hour");
				oprot.WriteI64((long)structs.GetBook_customer_in_24hour()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("book_customer_in_24hour can not be null!");
			}
			
			
			if(structs.GetNew_customer_in_24hour() != null) {
				
				oprot.WriteFieldBegin("new_customer_in_24hour");
				oprot.WriteI64((long)structs.GetNew_customer_in_24hour()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("new_customer_in_24hour can not be null!");
			}
			
			
			if(structs.GetCustomer_in_24hour() != null) {
				
				oprot.WriteFieldBegin("customer_in_24hour");
				oprot.WriteI64((long)structs.GetCustomer_in_24hour()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("customer_in_24hour can not be null!");
			}
			
			
			if(structs.GetBook_sales_in_24hour() != null) {
				
				oprot.WriteFieldBegin("book_sales_in_24hour");
				oprot.WriteI64((long)structs.GetBook_sales_in_24hour()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("book_sales_in_24hour can not be null!");
			}
			
			
			if(structs.GetSales_in_24hour() != null) {
				
				oprot.WriteFieldBegin("sales_in_24hour");
				oprot.WriteI64((long)structs.GetSales_in_24hour()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("sales_in_24hour can not be null!");
			}
			
			
			if(structs.GetBook_orders_in_24hour() != null) {
				
				oprot.WriteFieldBegin("book_orders_in_24hour");
				oprot.WriteI64((long)structs.GetBook_orders_in_24hour()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("book_orders_in_24hour can not be null!");
			}
			
			
			if(structs.GetOrders_in_24hour() != null) {
				
				oprot.WriteFieldBegin("orders_in_24hour");
				oprot.WriteI64((long)structs.GetOrders_in_24hour()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orders_in_24hour can not be null!");
			}
			
			
			if(structs.GetBook_roi_in_24hour() != null) {
				
				oprot.WriteFieldBegin("book_roi_in_24hour");
				oprot.WriteDouble((double)structs.GetBook_roi_in_24hour());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("book_roi_in_24hour can not be null!");
			}
			
			
			if(structs.GetRoi_in_24hour() != null) {
				
				oprot.WriteFieldBegin("roi_in_24hour");
				oprot.WriteDouble((double)structs.GetRoi_in_24hour());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("roi_in_24hour can not be null!");
			}
			
			
			if(structs.GetBook_customer_in_14day() != null) {
				
				oprot.WriteFieldBegin("book_customer_in_14day");
				oprot.WriteI64((long)structs.GetBook_customer_in_14day()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("book_customer_in_14day can not be null!");
			}
			
			
			if(structs.GetNew_customer_in_14day() != null) {
				
				oprot.WriteFieldBegin("new_customer_in_14day");
				oprot.WriteI64((long)structs.GetNew_customer_in_14day()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("new_customer_in_14day can not be null!");
			}
			
			
			if(structs.GetCustomer_in_14day() != null) {
				
				oprot.WriteFieldBegin("customer_in_14day");
				oprot.WriteI64((long)structs.GetCustomer_in_14day()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("customer_in_14day can not be null!");
			}
			
			
			if(structs.GetBook_sales_in_14day() != null) {
				
				oprot.WriteFieldBegin("book_sales_in_14day");
				oprot.WriteI64((long)structs.GetBook_sales_in_14day()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("book_sales_in_14day can not be null!");
			}
			
			
			if(structs.GetSales_in_14day() != null) {
				
				oprot.WriteFieldBegin("sales_in_14day");
				oprot.WriteI64((long)structs.GetSales_in_14day()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("sales_in_14day can not be null!");
			}
			
			
			if(structs.GetBook_orders_in_14day() != null) {
				
				oprot.WriteFieldBegin("book_orders_in_14day");
				oprot.WriteI64((long)structs.GetBook_orders_in_14day()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("book_orders_in_14day can not be null!");
			}
			
			
			if(structs.GetOrders_in_14day() != null) {
				
				oprot.WriteFieldBegin("orders_in_14day");
				oprot.WriteI64((long)structs.GetOrders_in_14day()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orders_in_14day can not be null!");
			}
			
			
			if(structs.GetBook_roi_in_14day() != null) {
				
				oprot.WriteFieldBegin("book_roi_in_14day");
				oprot.WriteDouble((double)structs.GetBook_roi_in_14day());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("book_roi_in_14day can not be null!");
			}
			
			
			if(structs.GetRoi_in_14day() != null) {
				
				oprot.WriteFieldBegin("roi_in_14day");
				oprot.WriteDouble((double)structs.GetRoi_in_14day());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("roi_in_14day can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(VopReportModel bean){
			
			
		}
		
	}
	
}