using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.common{
	
	
	
	
	
	public class ResultModel {
		
		///<summary>
		/// 状态码
		/// @sampleValue code 200
		///</summary>
		
		private int? code_;
		
		///<summary>
		/// 状态信息
		/// @sampleValue msg success
		///</summary>
		
		private string msg_;
		
		///<summary>
		/// 是否可继续提交
		///</summary>
		
		private bool? doNextStep_;
		
		///<summary>
		/// 文件服务器文件唯一标志
		///</summary>
		
		private string fid_;
		
		///<summary>
		/// 前端提示错误信息
		///</summary>
		
		private List<string> errorMsg_;
		
		///<summary>
		/// 处理数据总数量
		///</summary>
		
		private int? totalCount_;
		
		///<summary>
		/// 处理数据成功数量
		///</summary>
		
		private int? successCount_;
		
		///<summary>
		/// 处理数据失败数量
		///</summary>
		
		private int? failCount_;
		
		///<summary>
		/// 提示信息列表
		///</summary>
		
		private List<string> noticeMsgList_;
		
		///<summary>
		/// 返回错误类型
		///</summary>
		
		private string errorType_;
		
		public int? GetCode(){
			return this.code_;
		}
		
		public void SetCode(int? value){
			this.code_ = value;
		}
		public string GetMsg(){
			return this.msg_;
		}
		
		public void SetMsg(string value){
			this.msg_ = value;
		}
		public bool? GetDoNextStep(){
			return this.doNextStep_;
		}
		
		public void SetDoNextStep(bool? value){
			this.doNextStep_ = value;
		}
		public string GetFid(){
			return this.fid_;
		}
		
		public void SetFid(string value){
			this.fid_ = value;
		}
		public List<string> GetErrorMsg(){
			return this.errorMsg_;
		}
		
		public void SetErrorMsg(List<string> value){
			this.errorMsg_ = value;
		}
		public int? GetTotalCount(){
			return this.totalCount_;
		}
		
		public void SetTotalCount(int? value){
			this.totalCount_ = value;
		}
		public int? GetSuccessCount(){
			return this.successCount_;
		}
		
		public void SetSuccessCount(int? value){
			this.successCount_ = value;
		}
		public int? GetFailCount(){
			return this.failCount_;
		}
		
		public void SetFailCount(int? value){
			this.failCount_ = value;
		}
		public List<string> GetNoticeMsgList(){
			return this.noticeMsgList_;
		}
		
		public void SetNoticeMsgList(List<string> value){
			this.noticeMsgList_ = value;
		}
		public string GetErrorType(){
			return this.errorType_;
		}
		
		public void SetErrorType(string value){
			this.errorType_ = value;
		}
		
	}
	
}