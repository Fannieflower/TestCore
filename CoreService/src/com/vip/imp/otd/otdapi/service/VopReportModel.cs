using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.imp.otd.otdapi.service{
	
	
	
	
	
	public class VopReportModel {
		
		///<summary>
		/// 日期
		///</summary>
		
		private string date_;
		
		///<summary>
		/// 渠道
		///</summary>
		
		private com.vip.imp.otd.otdapi.service.VopDeliveryChannelType? channel_;
		
		///<summary>
		/// 推广计划Id
		///</summary>
		
		private string campaign_id_;
		
		///<summary>
		/// 推广计划名称
		///</summary>
		
		private string campaign_title_;
		
		///<summary>
		/// 广告Id
		///</summary>
		
		private string ad_id_;
		
		///<summary>
		/// 广告名称
		///</summary>
		
		private string ad_title_;
		
		///<summary>
		/// 资源位Id
		///</summary>
		
		private string placement_id_;
		
		///<summary>
		/// 资源位名称
		///</summary>
		
		private string placement_title_;
		
		///<summary>
		/// 曝光量
		///</summary>
		
		private long? impression_;
		
		///<summary>
		/// 点击量
		///</summary>
		
		private long? click_;
		
		///<summary>
		/// 消耗，单位为分
		///</summary>
		
		private long? cost_;
		
		///<summary>
		/// 点击率
		///</summary>
		
		private double? click_rate_;
		
		///<summary>
		/// CPC，单位为分
		///</summary>
		
		private long? cost_per_click_;
		
		///<summary>
		/// CPM，单位为分
		///</summary>
		
		private long? cost_per_mille_;
		
		///<summary>
		/// 唤起UV
		///</summary>
		
		private long? app_waken_uv_;
		
		///<summary>
		/// 唤起UV成本
		///</summary>
		
		private long? cost_per_app_waken_uv_;
		
		///<summary>
		/// 唤起PV
		///</summary>
		
		private long? app_waken_pv_;
		
		///<summary>
		/// 唤起率
		///</summary>
		
		private double? app_waken_rate_;
		
		///<summary>
		/// 小程序UV
		///</summary>
		
		private long? miniapp_uv_;
		
		///<summary>
		/// APP端UV
		///</summary>
		
		private long? app_uv_;
		
		///<summary>
		/// APP端UV成本
		///</summary>
		
		private long? cost_per_app_uv_;
		
		///<summary>
		/// 小程序UV成本
		///</summary>
		
		private long? cost_per_miniapp_uv_;
		
		///<summary>
		/// 专题页UV
		///</summary>
		
		private long? general_uv_;
		
		///<summary>
		/// 商品详情页UV
		///</summary>
		
		private long? product_uv_;
		
		///<summary>
		/// 档期页UV
		///</summary>
		
		private long? special_uv_;
		
		///<summary>
		/// 24小时下单客户数
		///</summary>
		
		private long? book_customer_in_24hour_;
		
		///<summary>
		/// 24小时成交新客数
		///</summary>
		
		private long? new_customer_in_24hour_;
		
		///<summary>
		/// 24小时成交客户数
		///</summary>
		
		private long? customer_in_24hour_;
		
		///<summary>
		/// 24小时订单额
		///</summary>
		
		private long? book_sales_in_24hour_;
		
		///<summary>
		/// 24小时销售额
		///</summary>
		
		private long? sales_in_24hour_;
		
		///<summary>
		/// 24小时下单量
		///</summary>
		
		private long? book_orders_in_24hour_;
		
		///<summary>
		/// 24小时成交单量
		///</summary>
		
		private long? orders_in_24hour_;
		
		///<summary>
		/// 24小时下单ROI
		///</summary>
		
		private double? book_roi_in_24hour_;
		
		///<summary>
		/// 24小时成交ROI
		///</summary>
		
		private double? roi_in_24hour_;
		
		///<summary>
		/// 14天下单客户数
		///</summary>
		
		private long? book_customer_in_14day_;
		
		///<summary>
		/// 14天成交新客数
		///</summary>
		
		private long? new_customer_in_14day_;
		
		///<summary>
		/// 14天成交客户数
		///</summary>
		
		private long? customer_in_14day_;
		
		///<summary>
		/// 14天订单额
		///</summary>
		
		private long? book_sales_in_14day_;
		
		///<summary>
		/// 14天销售额
		///</summary>
		
		private long? sales_in_14day_;
		
		///<summary>
		/// 14天下单量
		///</summary>
		
		private long? book_orders_in_14day_;
		
		///<summary>
		/// 14天成交单量
		///</summary>
		
		private long? orders_in_14day_;
		
		///<summary>
		/// 14天下单ROI
		///</summary>
		
		private double? book_roi_in_14day_;
		
		///<summary>
		/// 14天成交ROI
		///</summary>
		
		private double? roi_in_14day_;
		
		public string GetDate(){
			return this.date_;
		}
		
		public void SetDate(string value){
			this.date_ = value;
		}
		public com.vip.imp.otd.otdapi.service.VopDeliveryChannelType? GetChannel(){
			return this.channel_;
		}
		
		public void SetChannel(com.vip.imp.otd.otdapi.service.VopDeliveryChannelType? value){
			this.channel_ = value;
		}
		public string GetCampaign_id(){
			return this.campaign_id_;
		}
		
		public void SetCampaign_id(string value){
			this.campaign_id_ = value;
		}
		public string GetCampaign_title(){
			return this.campaign_title_;
		}
		
		public void SetCampaign_title(string value){
			this.campaign_title_ = value;
		}
		public string GetAd_id(){
			return this.ad_id_;
		}
		
		public void SetAd_id(string value){
			this.ad_id_ = value;
		}
		public string GetAd_title(){
			return this.ad_title_;
		}
		
		public void SetAd_title(string value){
			this.ad_title_ = value;
		}
		public string GetPlacement_id(){
			return this.placement_id_;
		}
		
		public void SetPlacement_id(string value){
			this.placement_id_ = value;
		}
		public string GetPlacement_title(){
			return this.placement_title_;
		}
		
		public void SetPlacement_title(string value){
			this.placement_title_ = value;
		}
		public long? GetImpression(){
			return this.impression_;
		}
		
		public void SetImpression(long? value){
			this.impression_ = value;
		}
		public long? GetClick(){
			return this.click_;
		}
		
		public void SetClick(long? value){
			this.click_ = value;
		}
		public long? GetCost(){
			return this.cost_;
		}
		
		public void SetCost(long? value){
			this.cost_ = value;
		}
		public double? GetClick_rate(){
			return this.click_rate_;
		}
		
		public void SetClick_rate(double? value){
			this.click_rate_ = value;
		}
		public long? GetCost_per_click(){
			return this.cost_per_click_;
		}
		
		public void SetCost_per_click(long? value){
			this.cost_per_click_ = value;
		}
		public long? GetCost_per_mille(){
			return this.cost_per_mille_;
		}
		
		public void SetCost_per_mille(long? value){
			this.cost_per_mille_ = value;
		}
		public long? GetApp_waken_uv(){
			return this.app_waken_uv_;
		}
		
		public void SetApp_waken_uv(long? value){
			this.app_waken_uv_ = value;
		}
		public long? GetCost_per_app_waken_uv(){
			return this.cost_per_app_waken_uv_;
		}
		
		public void SetCost_per_app_waken_uv(long? value){
			this.cost_per_app_waken_uv_ = value;
		}
		public long? GetApp_waken_pv(){
			return this.app_waken_pv_;
		}
		
		public void SetApp_waken_pv(long? value){
			this.app_waken_pv_ = value;
		}
		public double? GetApp_waken_rate(){
			return this.app_waken_rate_;
		}
		
		public void SetApp_waken_rate(double? value){
			this.app_waken_rate_ = value;
		}
		public long? GetMiniapp_uv(){
			return this.miniapp_uv_;
		}
		
		public void SetMiniapp_uv(long? value){
			this.miniapp_uv_ = value;
		}
		public long? GetApp_uv(){
			return this.app_uv_;
		}
		
		public void SetApp_uv(long? value){
			this.app_uv_ = value;
		}
		public long? GetCost_per_app_uv(){
			return this.cost_per_app_uv_;
		}
		
		public void SetCost_per_app_uv(long? value){
			this.cost_per_app_uv_ = value;
		}
		public long? GetCost_per_miniapp_uv(){
			return this.cost_per_miniapp_uv_;
		}
		
		public void SetCost_per_miniapp_uv(long? value){
			this.cost_per_miniapp_uv_ = value;
		}
		public long? GetGeneral_uv(){
			return this.general_uv_;
		}
		
		public void SetGeneral_uv(long? value){
			this.general_uv_ = value;
		}
		public long? GetProduct_uv(){
			return this.product_uv_;
		}
		
		public void SetProduct_uv(long? value){
			this.product_uv_ = value;
		}
		public long? GetSpecial_uv(){
			return this.special_uv_;
		}
		
		public void SetSpecial_uv(long? value){
			this.special_uv_ = value;
		}
		public long? GetBook_customer_in_24hour(){
			return this.book_customer_in_24hour_;
		}
		
		public void SetBook_customer_in_24hour(long? value){
			this.book_customer_in_24hour_ = value;
		}
		public long? GetNew_customer_in_24hour(){
			return this.new_customer_in_24hour_;
		}
		
		public void SetNew_customer_in_24hour(long? value){
			this.new_customer_in_24hour_ = value;
		}
		public long? GetCustomer_in_24hour(){
			return this.customer_in_24hour_;
		}
		
		public void SetCustomer_in_24hour(long? value){
			this.customer_in_24hour_ = value;
		}
		public long? GetBook_sales_in_24hour(){
			return this.book_sales_in_24hour_;
		}
		
		public void SetBook_sales_in_24hour(long? value){
			this.book_sales_in_24hour_ = value;
		}
		public long? GetSales_in_24hour(){
			return this.sales_in_24hour_;
		}
		
		public void SetSales_in_24hour(long? value){
			this.sales_in_24hour_ = value;
		}
		public long? GetBook_orders_in_24hour(){
			return this.book_orders_in_24hour_;
		}
		
		public void SetBook_orders_in_24hour(long? value){
			this.book_orders_in_24hour_ = value;
		}
		public long? GetOrders_in_24hour(){
			return this.orders_in_24hour_;
		}
		
		public void SetOrders_in_24hour(long? value){
			this.orders_in_24hour_ = value;
		}
		public double? GetBook_roi_in_24hour(){
			return this.book_roi_in_24hour_;
		}
		
		public void SetBook_roi_in_24hour(double? value){
			this.book_roi_in_24hour_ = value;
		}
		public double? GetRoi_in_24hour(){
			return this.roi_in_24hour_;
		}
		
		public void SetRoi_in_24hour(double? value){
			this.roi_in_24hour_ = value;
		}
		public long? GetBook_customer_in_14day(){
			return this.book_customer_in_14day_;
		}
		
		public void SetBook_customer_in_14day(long? value){
			this.book_customer_in_14day_ = value;
		}
		public long? GetNew_customer_in_14day(){
			return this.new_customer_in_14day_;
		}
		
		public void SetNew_customer_in_14day(long? value){
			this.new_customer_in_14day_ = value;
		}
		public long? GetCustomer_in_14day(){
			return this.customer_in_14day_;
		}
		
		public void SetCustomer_in_14day(long? value){
			this.customer_in_14day_ = value;
		}
		public long? GetBook_sales_in_14day(){
			return this.book_sales_in_14day_;
		}
		
		public void SetBook_sales_in_14day(long? value){
			this.book_sales_in_14day_ = value;
		}
		public long? GetSales_in_14day(){
			return this.sales_in_14day_;
		}
		
		public void SetSales_in_14day(long? value){
			this.sales_in_14day_ = value;
		}
		public long? GetBook_orders_in_14day(){
			return this.book_orders_in_14day_;
		}
		
		public void SetBook_orders_in_14day(long? value){
			this.book_orders_in_14day_ = value;
		}
		public long? GetOrders_in_14day(){
			return this.orders_in_14day_;
		}
		
		public void SetOrders_in_14day(long? value){
			this.orders_in_14day_ = value;
		}
		public double? GetBook_roi_in_14day(){
			return this.book_roi_in_14day_;
		}
		
		public void SetBook_roi_in_14day(double? value){
			this.book_roi_in_14day_ = value;
		}
		public double? GetRoi_in_14day(){
			return this.roi_in_14day_;
		}
		
		public void SetRoi_in_14day(double? value){
			this.roi_in_14day_ = value;
		}
		
	}
	
}