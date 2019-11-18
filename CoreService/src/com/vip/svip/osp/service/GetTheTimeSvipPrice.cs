using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class GetTheTimeSvipPrice {
		
		///<summary>
		/// 前端查询参数
		///</summary>
		
		private string param_;
		
		///<summary>
		/// warehouse
		///</summary>
		
		private string warehouse_;
		
		public string GetParam(){
			return this.param_;
		}
		
		public void SetParam(string value){
			this.param_ = value;
		}
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
		}
		
	}
	
}