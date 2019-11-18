using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.omni.logistics{
	
	
	
	
	
	public class ZtoRouteInfo {
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string billCode_;
		
		///<summary>
		/// 扫描类型，事件/操作，详情参见scanType编码规范
		///</summary>
		
		private string scanType_;
		
		///<summary>
		/// 扫描网点
		///</summary>
		
		private string scanSite_;
		
		///<summary>
		/// 扫描城市
		///</summary>
		
		private string scanCity_;
		
		///<summary>
		/// 扫描时间（yyyy-MM-dd HH:mm:ss）
		///</summary>
		
		private string scanDate_;
		
		///<summary>
		/// 物流信息描述
		///</summary>
		
		private string desc_;
		
		///<summary>
		/// 收/派件业务员姓名 或 签收客户姓名 或 代理点名称
		///</summary>
		
		private string contacts_;
		
		///<summary>
		/// 收/派件业务电话 或 代理点联系电话
		///</summary>
		
		private string contactsTel_;
		
		///<summary>
		/// 订阅的时，接口调用方自定义参数。如下单系统的订单号
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 值为[THIRD_PARTY_SIGN] 时，为代理点信息 当 [scantype] 为 [sign] 时关注
		///</summary>
		
		private string remark1_;
		
		///<summary>
		/// 代理点地址 当 [scantype] 为 [sign] 时关注
		///</summary>
		
		private string remark2_;
		
		///<summary>
		/// 问题件二级编码 	当 [scantype] 为 [PROBLEM] 时关注
		///</summary>
		
		private string remark3_;
		
		///<summary>
		/// 备注信息，后期约定，未用到的可以忽略
		///</summary>
		
		private string remark4_;
		
		///<summary>
		/// 同上
		///</summary>
		
		private string remark5_;
		
		///<summary>
		/// 同上
		///</summary>
		
		private string remark6_;
		
		public string GetBillCode(){
			return this.billCode_;
		}
		
		public void SetBillCode(string value){
			this.billCode_ = value;
		}
		public string GetScanType(){
			return this.scanType_;
		}
		
		public void SetScanType(string value){
			this.scanType_ = value;
		}
		public string GetScanSite(){
			return this.scanSite_;
		}
		
		public void SetScanSite(string value){
			this.scanSite_ = value;
		}
		public string GetScanCity(){
			return this.scanCity_;
		}
		
		public void SetScanCity(string value){
			this.scanCity_ = value;
		}
		public string GetScanDate(){
			return this.scanDate_;
		}
		
		public void SetScanDate(string value){
			this.scanDate_ = value;
		}
		public string GetDesc(){
			return this.desc_;
		}
		
		public void SetDesc(string value){
			this.desc_ = value;
		}
		public string GetContacts(){
			return this.contacts_;
		}
		
		public void SetContacts(string value){
			this.contacts_ = value;
		}
		public string GetContactsTel(){
			return this.contactsTel_;
		}
		
		public void SetContactsTel(string value){
			this.contactsTel_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public string GetRemark1(){
			return this.remark1_;
		}
		
		public void SetRemark1(string value){
			this.remark1_ = value;
		}
		public string GetRemark2(){
			return this.remark2_;
		}
		
		public void SetRemark2(string value){
			this.remark2_ = value;
		}
		public string GetRemark3(){
			return this.remark3_;
		}
		
		public void SetRemark3(string value){
			this.remark3_ = value;
		}
		public string GetRemark4(){
			return this.remark4_;
		}
		
		public void SetRemark4(string value){
			this.remark4_ = value;
		}
		public string GetRemark5(){
			return this.remark5_;
		}
		
		public void SetRemark5(string value){
			this.remark5_ = value;
		}
		public string GetRemark6(){
			return this.remark6_;
		}
		
		public void SetRemark6(string value){
			this.remark6_ = value;
		}
		
	}
	
}