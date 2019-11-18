using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class BrandGoodsPriceRequest {
		
		///<summary>
		/// userId
		///</summary>
		
		private long? userId_;
		
		///<summary>
		/// 站点
		///</summary>
		
		private string warehouse_;
		
		///<summary>
		/// 商品id列表
		///</summary>
		
		private List<long?> ids_;
		
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
		}
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
		}
		public List<long?> GetIds(){
			return this.ids_;
		}
		
		public void SetIds(List<long?> value){
			this.ids_ = value;
		}
		
	}
	
}