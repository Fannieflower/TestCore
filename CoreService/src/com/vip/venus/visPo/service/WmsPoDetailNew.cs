using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.venus.visPo.service{
	
	
	
	
	
	public class WmsPoDetailNew {
		
		///<summary>
		/// id
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// po采购单号
		///</summary>
		
		private string po_;
		
		///<summary>
		/// 条码
		///</summary>
		
		private string itemNo_;
		
		///<summary>
		/// 采购数量
		///</summary>
		
		private int? poQty_;
		
		///<summary>
		/// 供应商名称
		///</summary>
		
		private string vendorName_;
		
		///<summary>
		/// 吊牌价
		///</summary>
		
		private string tagPrice_;
		
		///<summary>
		/// 是否防盗扣 Y代表含有防盗扣，N代表不含防盗扣
		///</summary>
		
		private string antiTheftClasp_;
		
		///<summary>
		/// 创建时间
		///</summary>
		
		private System.DateTime? createTime_;
		
		///<summary>
		/// 更新时间
		///</summary>
		
		private System.DateTime? updateTime_;
		
		///<summary>
		/// 买手组编码
		///</summary>
		
		private string buyerGroupCode_;
		
		///<summary>
		/// 采购不含税价格
		///</summary>
		
		private double? poUnitPrice_;
		
		///<summary>
		/// 税率
		///</summary>
		
		private double? taxRate_;
		
		///<summary>
		/// 采购含税价格
		///</summary>
		
		private double? priceWithTax_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public string GetPo(){
			return this.po_;
		}
		
		public void SetPo(string value){
			this.po_ = value;
		}
		public string GetItemNo(){
			return this.itemNo_;
		}
		
		public void SetItemNo(string value){
			this.itemNo_ = value;
		}
		public int? GetPoQty(){
			return this.poQty_;
		}
		
		public void SetPoQty(int? value){
			this.poQty_ = value;
		}
		public string GetVendorName(){
			return this.vendorName_;
		}
		
		public void SetVendorName(string value){
			this.vendorName_ = value;
		}
		public string GetTagPrice(){
			return this.tagPrice_;
		}
		
		public void SetTagPrice(string value){
			this.tagPrice_ = value;
		}
		public string GetAntiTheftClasp(){
			return this.antiTheftClasp_;
		}
		
		public void SetAntiTheftClasp(string value){
			this.antiTheftClasp_ = value;
		}
		public System.DateTime? GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(System.DateTime? value){
			this.createTime_ = value;
		}
		public System.DateTime? GetUpdateTime(){
			return this.updateTime_;
		}
		
		public void SetUpdateTime(System.DateTime? value){
			this.updateTime_ = value;
		}
		public string GetBuyerGroupCode(){
			return this.buyerGroupCode_;
		}
		
		public void SetBuyerGroupCode(string value){
			this.buyerGroupCode_ = value;
		}
		public double? GetPoUnitPrice(){
			return this.poUnitPrice_;
		}
		
		public void SetPoUnitPrice(double? value){
			this.poUnitPrice_ = value;
		}
		public double? GetTaxRate(){
			return this.taxRate_;
		}
		
		public void SetTaxRate(double? value){
			this.taxRate_ = value;
		}
		public double? GetPriceWithTax(){
			return this.priceWithTax_;
		}
		
		public void SetPriceWithTax(double? value){
			this.priceWithTax_ = value;
		}
		
	}
	
}