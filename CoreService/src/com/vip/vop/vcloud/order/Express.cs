using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.order{
	
	
	
	
	
	public class Express {
		
		///<summary>
		/// 快递公司
		///</summary>
		
		private string expressCompany_;
		
		///<summary>
		/// 快递单号
		///</summary>
		
		private string expressNo_;
		
		///<summary>
		/// 快递清单列表
		///</summary>
		
		private List<com.vip.vop.vcloud.order.ExpressList> expressLists_;
		
		public string GetExpressCompany(){
			return this.expressCompany_;
		}
		
		public void SetExpressCompany(string value){
			this.expressCompany_ = value;
		}
		public string GetExpressNo(){
			return this.expressNo_;
		}
		
		public void SetExpressNo(string value){
			this.expressNo_ = value;
		}
		public List<com.vip.vop.vcloud.order.ExpressList> GetExpressLists(){
			return this.expressLists_;
		}
		
		public void SetExpressLists(List<com.vip.vop.vcloud.order.ExpressList> value){
			this.expressLists_ = value;
		}
		
	}
	
}