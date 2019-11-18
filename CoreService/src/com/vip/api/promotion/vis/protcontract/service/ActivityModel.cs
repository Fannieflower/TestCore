using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ActivityModel {
		
		///<summary>
		/// 上线时间
		///</summary>
		
		private string onlineStarttime_;
		
		///<summary>
		/// 下线时间
		///</summary>
		
		private string onlineEndtime_;
		
		///<summary>
		/// 活动商品列表
		///</summary>
		
		private List<com.vip.api.promotion.vis.protcontract.service.CommodityModel> commodityList_;
		
		public string GetOnlineStarttime(){
			return this.onlineStarttime_;
		}
		
		public void SetOnlineStarttime(string value){
			this.onlineStarttime_ = value;
		}
		public string GetOnlineEndtime(){
			return this.onlineEndtime_;
		}
		
		public void SetOnlineEndtime(string value){
			this.onlineEndtime_ = value;
		}
		public List<com.vip.api.promotion.vis.protcontract.service.CommodityModel> GetCommodityList(){
			return this.commodityList_;
		}
		
		public void SetCommodityList(List<com.vip.api.promotion.vis.protcontract.service.CommodityModel> value){
			this.commodityList_ = value;
		}
		
	}
	
}