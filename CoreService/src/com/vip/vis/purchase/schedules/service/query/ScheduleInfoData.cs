using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	
	
	public class ScheduleInfoData {
		
		///<summary>
		/// 档期ID
		///</summary>
		
		private long? brandId_;
		
		///<summary>
		/// 合作模式
		///</summary>
		
		private byte? sellingMode_;
		
		///<summary>
		/// 采购协议名称
		///</summary>
		
		private string sellingAction_;
		
		///<summary>
		/// 销售模式
		///</summary>
		
		private int? b2cModeId_;
		
		///<summary>
		/// 采购协议有效开始时间
		///</summary>
		
		private System.DateTime? sellTimeFrom_;
		
		///<summary>
		/// 采购协议有效结束时间
		///</summary>
		
		private System.DateTime? sellTimeTo_;
		
		///<summary>
		/// 是否运营专场
		///</summary>
		
		private byte? specialOperationsFlag_;
		
		///<summary>
		/// 是否快速生成专场
		///</summary>
		
		private byte? exclusiveOrShare_;
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private int? vendorCode_;
		
		///<summary>
		/// 供应商名称
		///</summary>
		
		private string vendorName_;
		
		///<summary>
		/// 分仓
		///</summary>
		
		private string sellArea_;
		
		///<summary>
		/// 分销站点
		///</summary>
		
		private string distributionSites_;
		
		///<summary>
		/// 创建时间
		///</summary>
		
		private System.DateTime? createTime_;
		
		///<summary>
		/// 修改时间
		///</summary>
		
		private System.DateTime? updateTime_;
		
		///<summary>
		/// 创建人
		///</summary>
		
		private string createBy_;
		
		///<summary>
		/// 是否是常态档期
		///</summary>
		
		private byte? normalityFlag_;
		
		public long? GetBrandId(){
			return this.brandId_;
		}
		
		public void SetBrandId(long? value){
			this.brandId_ = value;
		}
		public byte? GetSellingMode(){
			return this.sellingMode_;
		}
		
		public void SetSellingMode(byte? value){
			this.sellingMode_ = value;
		}
		public string GetSellingAction(){
			return this.sellingAction_;
		}
		
		public void SetSellingAction(string value){
			this.sellingAction_ = value;
		}
		public int? GetB2cModeId(){
			return this.b2cModeId_;
		}
		
		public void SetB2cModeId(int? value){
			this.b2cModeId_ = value;
		}
		public System.DateTime? GetSellTimeFrom(){
			return this.sellTimeFrom_;
		}
		
		public void SetSellTimeFrom(System.DateTime? value){
			this.sellTimeFrom_ = value;
		}
		public System.DateTime? GetSellTimeTo(){
			return this.sellTimeTo_;
		}
		
		public void SetSellTimeTo(System.DateTime? value){
			this.sellTimeTo_ = value;
		}
		public byte? GetSpecialOperationsFlag(){
			return this.specialOperationsFlag_;
		}
		
		public void SetSpecialOperationsFlag(byte? value){
			this.specialOperationsFlag_ = value;
		}
		public byte? GetExclusiveOrShare(){
			return this.exclusiveOrShare_;
		}
		
		public void SetExclusiveOrShare(byte? value){
			this.exclusiveOrShare_ = value;
		}
		public int? GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(int? value){
			this.vendorCode_ = value;
		}
		public string GetVendorName(){
			return this.vendorName_;
		}
		
		public void SetVendorName(string value){
			this.vendorName_ = value;
		}
		public string GetSellArea(){
			return this.sellArea_;
		}
		
		public void SetSellArea(string value){
			this.sellArea_ = value;
		}
		public string GetDistributionSites(){
			return this.distributionSites_;
		}
		
		public void SetDistributionSites(string value){
			this.distributionSites_ = value;
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
		public string GetCreateBy(){
			return this.createBy_;
		}
		
		public void SetCreateBy(string value){
			this.createBy_ = value;
		}
		public byte? GetNormalityFlag(){
			return this.normalityFlag_;
		}
		
		public void SetNormalityFlag(byte? value){
			this.normalityFlag_ = value;
		}
		
	}
	
}