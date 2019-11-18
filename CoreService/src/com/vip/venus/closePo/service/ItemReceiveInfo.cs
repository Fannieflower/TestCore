using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.venus.closePo.service{
	
	
	
	
	
	public class ItemReceiveInfo {
		
		///<summary>
		/// 条码
		///</summary>
		
		private string itemBarCode_;
		
		///<summary>
		/// 已收货总数
		///</summary>
		
		private int? recAmount_;
		
		public string GetItemBarCode(){
			return this.itemBarCode_;
		}
		
		public void SetItemBarCode(string value){
			this.itemBarCode_ = value;
		}
		public int? GetRecAmount(){
			return this.recAmount_;
		}
		
		public void SetRecAmount(int? value){
			this.recAmount_ = value;
		}
		
	}
	
}