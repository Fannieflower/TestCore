using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PmsPayHouseModel {
		
		///<summary>
		/// 活动编号 pms_active_warehouse.act_warehouse_no
		///</summary>
		
		private string activeNo_;
		
		///<summary>
		/// 优惠力度
		///</summary>
		
		private List<com.vip.pms.data.service.PmsPayFavModel> payFavModelList_;
		
		public string GetActiveNo(){
			return this.activeNo_;
		}
		
		public void SetActiveNo(string value){
			this.activeNo_ = value;
		}
		public List<com.vip.pms.data.service.PmsPayFavModel> GetPayFavModelList(){
			return this.payFavModelList_;
		}
		
		public void SetPayFavModelList(List<com.vip.pms.data.service.PmsPayFavModel> value){
			this.payFavModelList_ = value;
		}
		
	}
	
}