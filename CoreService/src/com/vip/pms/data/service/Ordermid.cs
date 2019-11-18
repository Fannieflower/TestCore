using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class Ordermid {
		
		///<summary>
		/// 商品ID
		///</summary>
		
		private string merchandiseId_;
		
		///<summary>
		/// 商品数量
		///</summary>
		
		private int? amount_;
		
		///<summary>
		/// 引用号，相应类型的号码，如活动号、专享价号等
		///</summary>
		
		private string refNo_;
		
		public string GetMerchandiseId(){
			return this.merchandiseId_;
		}
		
		public void SetMerchandiseId(string value){
			this.merchandiseId_ = value;
		}
		public int? GetAmount(){
			return this.amount_;
		}
		
		public void SetAmount(int? value){
			this.amount_ = value;
		}
		public string GetRefNo(){
			return this.refNo_;
		}
		
		public void SetRefNo(string value){
			this.refNo_ = value;
		}
		
	}
	
}