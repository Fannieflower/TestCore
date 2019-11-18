using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class GetGoodsIdByPickNoReq {
		
		///<summary>
		/// 选品id
		///</summary>
		
		private long? pickNo_;
		
		///<summary>
		/// warehouse
		///</summary>
		
		private string warehouse_;
		
		public long? GetPickNo(){
			return this.pickNo_;
		}
		
		public void SetPickNo(long? value){
			this.pickNo_ = value;
		}
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
		}
		
	}
	
}