using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class GetSvipGoodsDetailReq {
		
		///<summary>
		/// 站点
		///</summary>
		
		private string warehouse_;
		
		///<summary>
		/// goodsIds
		///</summary>
		
		private string goodsIds_;
		
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
		}
		public string GetGoodsIds(){
			return this.goodsIds_;
		}
		
		public void SetGoodsIds(string value){
			this.goodsIds_ = value;
		}
		
	}
	
}