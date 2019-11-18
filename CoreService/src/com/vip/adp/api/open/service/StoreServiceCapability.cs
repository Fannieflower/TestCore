using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class StoreServiceCapability {
		
		///<summary>
		/// 店铺评分：保留两位小数
		///</summary>
		
		private string storeScore_;
		
		///<summary>
		/// 店铺同品类排名比例：例如10表示前10%
		///</summary>
		
		private string storeRankRate_;
		
		public string GetStoreScore(){
			return this.storeScore_;
		}
		
		public void SetStoreScore(string value){
			this.storeScore_ = value;
		}
		public string GetStoreRankRate(){
			return this.storeRankRate_;
		}
		
		public void SetStoreRankRate(string value){
			this.storeRankRate_ = value;
		}
		
	}
	
}