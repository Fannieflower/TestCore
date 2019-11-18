using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class UrlInfo {
		
		///<summary>
		/// 链接生成的数据源：
		///如果targetType为GOODSID，该值商品id，
		///如果targetType为URL，该值为唯品会url，
		///如果targetType为VIP_SMALL和GENERAL_SAMLL时，该值为空（此类型VOP暂未开放）
		///</summary>
		
		private string source_;
		
		///<summary>
		/// CPS短链接
		///</summary>
		
		private string url_;
		
		///<summary>
		/// CPS长连接
		///</summary>
		
		private string longUrl_;
		
		///<summary>
		/// CPS通用连接
		///</summary>
		
		private string ulUrl_;
		
		///<summary>
		/// CPS Deeplink链接
		///</summary>
		
		private string deeplinkUrl_;
		
		///<summary>
		/// 小程序CPS参数，如果targetType为VIP_SMALL和GENERAL_SAMLL时，该参数将被赋值
		///</summary>
		
		private string traFrom_;
		
		///<summary>
		/// CPS短链接：非唤起链接
		///</summary>
		
		private string noEvokeUrl_;
		
		///<summary>
		/// CPS长链接：非唤起链接
		///</summary>
		
		private string noEvokeLongUrl_;
		
		///<summary>
		/// 唯品会小程序链接：仅在根据商品id获取时返回
		///</summary>
		
		private string vipWxUrl_;
		
		///<summary>
		/// 唯品会小程序码：仅在根据商品id获取时返回
		///</summary>
		
		private string vipWxCode_;
		
		///<summary>
		/// 唯品会快应用链接
		///</summary>
		
		private string vipQuickAppUrl_;
		
		public string GetSource(){
			return this.source_;
		}
		
		public void SetSource(string value){
			this.source_ = value;
		}
		public string GetUrl(){
			return this.url_;
		}
		
		public void SetUrl(string value){
			this.url_ = value;
		}
		public string GetLongUrl(){
			return this.longUrl_;
		}
		
		public void SetLongUrl(string value){
			this.longUrl_ = value;
		}
		public string GetUlUrl(){
			return this.ulUrl_;
		}
		
		public void SetUlUrl(string value){
			this.ulUrl_ = value;
		}
		public string GetDeeplinkUrl(){
			return this.deeplinkUrl_;
		}
		
		public void SetDeeplinkUrl(string value){
			this.deeplinkUrl_ = value;
		}
		public string GetTraFrom(){
			return this.traFrom_;
		}
		
		public void SetTraFrom(string value){
			this.traFrom_ = value;
		}
		public string GetNoEvokeUrl(){
			return this.noEvokeUrl_;
		}
		
		public void SetNoEvokeUrl(string value){
			this.noEvokeUrl_ = value;
		}
		public string GetNoEvokeLongUrl(){
			return this.noEvokeLongUrl_;
		}
		
		public void SetNoEvokeLongUrl(string value){
			this.noEvokeLongUrl_ = value;
		}
		public string GetVipWxUrl(){
			return this.vipWxUrl_;
		}
		
		public void SetVipWxUrl(string value){
			this.vipWxUrl_ = value;
		}
		public string GetVipWxCode(){
			return this.vipWxCode_;
		}
		
		public void SetVipWxCode(string value){
			this.vipWxCode_ = value;
		}
		public string GetVipQuickAppUrl(){
			return this.vipQuickAppUrl_;
		}
		
		public void SetVipQuickAppUrl(string value){
			this.vipQuickAppUrl_ = value;
		}
		
	}
	
}