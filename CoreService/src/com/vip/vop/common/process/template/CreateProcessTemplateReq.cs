using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.common.process.template{
	
	
	
	
	
	public class CreateProcessTemplateReq {
		
		///<summary>
		/// 操作人ID
		///</summary>
		
		private string opUserId_;
		
		///<summary>
		/// 操作人名称
		///</summary>
		
		private string opUserName_;
		
		///<summary>
		/// 所属应用
		///</summary>
		
		private string app_;
		
		///<summary>
		/// 业务类型
		///</summary>
		
		private string bizType_;
		
		///<summary>
		/// 流程模板名称
		///</summary>
		
		private string templateName_;
		
		///<summary>
		/// 流程模板版本号
		///</summary>
		
		private short? templateVersion_;
		
		///<summary>
		/// 流程模板内容
		///</summary>
		
		private string templateContent_;
		
		public string GetOpUserId(){
			return this.opUserId_;
		}
		
		public void SetOpUserId(string value){
			this.opUserId_ = value;
		}
		public string GetOpUserName(){
			return this.opUserName_;
		}
		
		public void SetOpUserName(string value){
			this.opUserName_ = value;
		}
		public string GetApp(){
			return this.app_;
		}
		
		public void SetApp(string value){
			this.app_ = value;
		}
		public string GetBizType(){
			return this.bizType_;
		}
		
		public void SetBizType(string value){
			this.bizType_ = value;
		}
		public string GetTemplateName(){
			return this.templateName_;
		}
		
		public void SetTemplateName(string value){
			this.templateName_ = value;
		}
		public short? GetTemplateVersion(){
			return this.templateVersion_;
		}
		
		public void SetTemplateVersion(short? value){
			this.templateVersion_ = value;
		}
		public string GetTemplateContent(){
			return this.templateContent_;
		}
		
		public void SetTemplateContent(string value){
			this.templateContent_ = value;
		}
		
	}
	
}