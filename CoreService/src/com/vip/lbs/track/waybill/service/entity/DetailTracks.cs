using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.lbs.track.waybill.service.entity{
	
	
	
	
	
	public class DetailTracks {
		
		///<summary>
		/// 操作状态: 10. 揽件；20. 运输；30. 派送；40. 签收；50. 拒收；70. 转寄
		///</summary>
		
		private int? state_;
		
		///<summary>
		/// 描述
		///</summary>
		
		private string trackDesc_;
		
		///<summary>
		/// 派件员
		///</summary>
		
		private string dispRecMan_;
		
		///<summary>
		/// 派件员电话
		///</summary>
		
		private string dispRecManPhone_;
		
		///<summary>
		/// 派件或收件员电话
		///</summary>
		
		private string scanType_;
		
		///<summary>
		/// 上一站或下一站城市
		///</summary>
		
		private string preNextCity_;
		
		///<summary>
		/// 上一站或下一站省
		///</summary>
		
		private string preNextProv_;
		
		///<summary>
		/// 上一站或下一站站点
		///</summary>
		
		private string preNextSite_;
		
		///<summary>
		/// 上一站或下一站站点编码
		///</summary>
		
		private string preNextSiteCode_;
		
		///<summary>
		/// 上一站或下一站站点电话
		///</summary>
		
		private string preNextSitePhone_;
		
		///<summary>
		/// 签收人
		///</summary>
		
		private string signMan_;
		
		///<summary>
		/// 扫描站点电话
		///</summary>
		
		private string scanSitePhone_;
		
		///<summary>
		/// 备注
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 轨迹产生时间
		///</summary>
		
		private long? trackCreateTime_;
		
		///<summary>
		/// 承运商的轨迹code
		///</summary>
		
		private string trackCode_;
		
		///<summary>
		/// 站点编码
		///</summary>
		
		private string siteCode_;
		
		///<summary>
		/// 站点名称
		///</summary>
		
		private string siteName_;
		
		///<summary>
		/// 扩展字段，Key值：signAddress；描述：代签收详细地址
		///</summary>
		
		private Dictionary<string, string> extendFields_;
		
		public int? GetState(){
			return this.state_;
		}
		
		public void SetState(int? value){
			this.state_ = value;
		}
		public string GetTrackDesc(){
			return this.trackDesc_;
		}
		
		public void SetTrackDesc(string value){
			this.trackDesc_ = value;
		}
		public string GetDispRecMan(){
			return this.dispRecMan_;
		}
		
		public void SetDispRecMan(string value){
			this.dispRecMan_ = value;
		}
		public string GetDispRecManPhone(){
			return this.dispRecManPhone_;
		}
		
		public void SetDispRecManPhone(string value){
			this.dispRecManPhone_ = value;
		}
		public string GetScanType(){
			return this.scanType_;
		}
		
		public void SetScanType(string value){
			this.scanType_ = value;
		}
		public string GetPreNextCity(){
			return this.preNextCity_;
		}
		
		public void SetPreNextCity(string value){
			this.preNextCity_ = value;
		}
		public string GetPreNextProv(){
			return this.preNextProv_;
		}
		
		public void SetPreNextProv(string value){
			this.preNextProv_ = value;
		}
		public string GetPreNextSite(){
			return this.preNextSite_;
		}
		
		public void SetPreNextSite(string value){
			this.preNextSite_ = value;
		}
		public string GetPreNextSiteCode(){
			return this.preNextSiteCode_;
		}
		
		public void SetPreNextSiteCode(string value){
			this.preNextSiteCode_ = value;
		}
		public string GetPreNextSitePhone(){
			return this.preNextSitePhone_;
		}
		
		public void SetPreNextSitePhone(string value){
			this.preNextSitePhone_ = value;
		}
		public string GetSignMan(){
			return this.signMan_;
		}
		
		public void SetSignMan(string value){
			this.signMan_ = value;
		}
		public string GetScanSitePhone(){
			return this.scanSitePhone_;
		}
		
		public void SetScanSitePhone(string value){
			this.scanSitePhone_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public long? GetTrackCreateTime(){
			return this.trackCreateTime_;
		}
		
		public void SetTrackCreateTime(long? value){
			this.trackCreateTime_ = value;
		}
		public string GetTrackCode(){
			return this.trackCode_;
		}
		
		public void SetTrackCode(string value){
			this.trackCode_ = value;
		}
		public string GetSiteCode(){
			return this.siteCode_;
		}
		
		public void SetSiteCode(string value){
			this.siteCode_ = value;
		}
		public string GetSiteName(){
			return this.siteName_;
		}
		
		public void SetSiteName(string value){
			this.siteName_ = value;
		}
		public Dictionary<string, string> GetExtendFields(){
			return this.extendFields_;
		}
		
		public void SetExtendFields(Dictionary<string, string> value){
			this.extendFields_ = value;
		}
		
	}
	
}