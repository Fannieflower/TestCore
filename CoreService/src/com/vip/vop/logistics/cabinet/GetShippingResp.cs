using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.cabinet{
	
	
	
	
	
	public class GetShippingResp {
		
		///<summary>
		/// 运单列表
		///</summary>
		
		private List<com.vip.vop.logistics.cabinet.Shipping> shippings_;
		
		public List<com.vip.vop.logistics.cabinet.Shipping> GetShippings(){
			return this.shippings_;
		}
		
		public void SetShippings(List<com.vip.vop.logistics.cabinet.Shipping> value){
			this.shippings_ = value;
		}
		
	}
	
}