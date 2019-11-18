using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PmsActPsScopeModel {
		
		///<summary>
		/// 商品ID
		///</summary>
		
		private int? goodsId_;
		
		///<summary>
		/// scopeId
		///</summary>
		
		private long? scopeId_;
		
		///<summary>
		/// 商品名字
		///</summary>
		
		private string goodsName_;
		
		///<summary>
		/// 商品价格
		///</summary>
		
		private string goodsPrice_;
		
		///<summary>
		/// 档期ID
		///</summary>
		
		private int? brandId_;
		
		///<summary>
		/// 档期名字
		///</summary>
		
		private string brandName_;
		
		///<summary>
		/// 销售模式
		///</summary>
		
		private int? saleStyle_;
		
		///<summary>
		/// 分仓
		///</summary>
		
		private string saleSite_;
		
		///<summary>
		/// 商品ID
		///</summary>
		
		private long? merNo_;
		
		///<summary>
		/// 档期ID
		///</summary>
		
		private long? salesNo_;
		
		public int? GetGoodsId(){
			return this.goodsId_;
		}
		
		public void SetGoodsId(int? value){
			this.goodsId_ = value;
		}
		public long? GetScopeId(){
			return this.scopeId_;
		}
		
		public void SetScopeId(long? value){
			this.scopeId_ = value;
		}
		public string GetGoodsName(){
			return this.goodsName_;
		}
		
		public void SetGoodsName(string value){
			this.goodsName_ = value;
		}
		public string GetGoodsPrice(){
			return this.goodsPrice_;
		}
		
		public void SetGoodsPrice(string value){
			this.goodsPrice_ = value;
		}
		public int? GetBrandId(){
			return this.brandId_;
		}
		
		public void SetBrandId(int? value){
			this.brandId_ = value;
		}
		public string GetBrandName(){
			return this.brandName_;
		}
		
		public void SetBrandName(string value){
			this.brandName_ = value;
		}
		public int? GetSaleStyle(){
			return this.saleStyle_;
		}
		
		public void SetSaleStyle(int? value){
			this.saleStyle_ = value;
		}
		public string GetSaleSite(){
			return this.saleSite_;
		}
		
		public void SetSaleSite(string value){
			this.saleSite_ = value;
		}
		public long? GetMerNo(){
			return this.merNo_;
		}
		
		public void SetMerNo(long? value){
			this.merNo_ = value;
		}
		public long? GetSalesNo(){
			return this.salesNo_;
		}
		
		public void SetSalesNo(long? value){
			this.salesNo_ = value;
		}
		
	}
	
}