using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.price{
	
	
	
	
	
	public class ProdItemSettlementPriceResp {
		
		///<summary>
		/// 结算价格
		///</summary>
		
		private string settlementPrice_;
		
		///<summary>
		/// 销售价格
		///</summary>
		
		private string salePrice_;
		
		///<summary>
		/// 扣点,小数点，0-1之间
		///</summary>
		
		private string deduction_;
		
		public string GetSettlementPrice(){
			return this.settlementPrice_;
		}
		
		public void SetSettlementPrice(string value){
			this.settlementPrice_ = value;
		}
		public string GetSalePrice(){
			return this.salePrice_;
		}
		
		public void SetSalePrice(string value){
			this.salePrice_ = value;
		}
		public string GetDeduction(){
			return this.deduction_;
		}
		
		public void SetDeduction(string value){
			this.deduction_ = value;
		}
		
	}
	
}