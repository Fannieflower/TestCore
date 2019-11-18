using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.venus.visPo.service{
	
	
	
	
	
	public class WmsPoLine {
		
		///<summary>
		/// 采购订单行唯一ID,用来标识行记录接口字段，从1开始，顺序排列。//请小峰和WMS开发同事碰一下这个字段。
		///</summary>
		
		private string po_line_id_;
		
		///<summary>
		/// 采购订单行序号采购单行号，取PO行表的line_num字段
		///</summary>
		
		private string line_num_;
		
		///<summary>
		/// 采购订单行商品编码行表的item_no
		///</summary>
		
		private string item_code_;
		
		///<summary>
		/// 采购订单行采购数量行表的po_qty
		///</summary>
		
		private string quantity_;
		
		///<summary>
		/// 采购订单行采购箱数传空，暂时无法取值
		///</summary>
		
		private string volume_qty_;
		
		///<summary>
		/// 用来标识SCM传送采购订单行表的状态NEW 新建条码
		///</summary>
		
		private string status_;
		
		///<summary>
		/// 更新条码写成和头表STATUS一致
		///</summary>
		
		private string update_;
		
		///<summary>
		/// 行表tag_price
		///</summary>
		
		private string selling_price_;
		
		///<summary>
		/// 防盗扣行表anti_theft_clasp
		///</summary>
		
		private string anti_theft_clasp_;
		
		///<summary>
		/// 实物最早生产日期
		///</summary>
		
		private string productionDate_;
		
		///<summary>
		/// 实物最早过期日期
		///</summary>
		
		private string expireDate_;
		
		///<summary>
		/// 批准文号
		///</summary>
		
		private string approval_;
		
		///<summary>
		/// 批准文号效期
		///</summary>
		
		private string approvalTerm_;
		
		///<summary>
		/// 采购含税价格
		///</summary>
		
		private string priceWithTax_;
		
		///<summary>
		/// 品牌SN
		///</summary>
		
		private string brandSn_;
		
		///<summary>
		/// 品牌名称
		///</summary>
		
		private string brandName_;
		
		///<summary>
		/// 品牌名称En
		///</summary>
		
		private string brandNameEn_;
		
		///<summary>
		/// 服务等级
		///</summary>
		
		private string tagGroupName_;
		
		///<summary>
		/// 商品原条码
		///</summary>
		
		private string oldItemNo_;
		
		public string GetPo_line_id(){
			return this.po_line_id_;
		}
		
		public void SetPo_line_id(string value){
			this.po_line_id_ = value;
		}
		public string GetLine_num(){
			return this.line_num_;
		}
		
		public void SetLine_num(string value){
			this.line_num_ = value;
		}
		public string GetItem_code(){
			return this.item_code_;
		}
		
		public void SetItem_code(string value){
			this.item_code_ = value;
		}
		public string GetQuantity(){
			return this.quantity_;
		}
		
		public void SetQuantity(string value){
			this.quantity_ = value;
		}
		public string GetVolume_qty(){
			return this.volume_qty_;
		}
		
		public void SetVolume_qty(string value){
			this.volume_qty_ = value;
		}
		public string GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(string value){
			this.status_ = value;
		}
		public string GetUpdate(){
			return this.update_;
		}
		
		public void SetUpdate(string value){
			this.update_ = value;
		}
		public string GetSelling_price(){
			return this.selling_price_;
		}
		
		public void SetSelling_price(string value){
			this.selling_price_ = value;
		}
		public string GetAnti_theft_clasp(){
			return this.anti_theft_clasp_;
		}
		
		public void SetAnti_theft_clasp(string value){
			this.anti_theft_clasp_ = value;
		}
		public string GetProductionDate(){
			return this.productionDate_;
		}
		
		public void SetProductionDate(string value){
			this.productionDate_ = value;
		}
		public string GetExpireDate(){
			return this.expireDate_;
		}
		
		public void SetExpireDate(string value){
			this.expireDate_ = value;
		}
		public string GetApproval(){
			return this.approval_;
		}
		
		public void SetApproval(string value){
			this.approval_ = value;
		}
		public string GetApprovalTerm(){
			return this.approvalTerm_;
		}
		
		public void SetApprovalTerm(string value){
			this.approvalTerm_ = value;
		}
		public string GetPriceWithTax(){
			return this.priceWithTax_;
		}
		
		public void SetPriceWithTax(string value){
			this.priceWithTax_ = value;
		}
		public string GetBrandSn(){
			return this.brandSn_;
		}
		
		public void SetBrandSn(string value){
			this.brandSn_ = value;
		}
		public string GetBrandName(){
			return this.brandName_;
		}
		
		public void SetBrandName(string value){
			this.brandName_ = value;
		}
		public string GetBrandNameEn(){
			return this.brandNameEn_;
		}
		
		public void SetBrandNameEn(string value){
			this.brandNameEn_ = value;
		}
		public string GetTagGroupName(){
			return this.tagGroupName_;
		}
		
		public void SetTagGroupName(string value){
			this.tagGroupName_ = value;
		}
		public string GetOldItemNo(){
			return this.oldItemNo_;
		}
		
		public void SetOldItemNo(string value){
			this.oldItemNo_ = value;
		}
		
	}
	
}