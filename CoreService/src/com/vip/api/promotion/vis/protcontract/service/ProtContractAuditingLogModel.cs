using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ProtContractAuditingLogModel {
		
		///<summary>
		/// 确认函ID
		///</summary>
		
		private long? mainId_;
		
		///<summary>
		/// 状态
		///</summary>
		
		private byte? status_;
		
		///<summary>
		/// 描述
		///</summary>
		
		private string auditdesc_;
		
		///<summary>
		/// 备注
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 部门
		///</summary>
		
		private string dataAreaName_;
		
		///<summary>
		/// 操作人
		///</summary>
		
		private string userNickName_;
		
		///<summary>
		/// 修改时间
		///</summary>
		
		private long? updateTime_;
		
		///<summary>
		/// 创建时间
		///</summary>
		
		private long? createTime_;
		
		public long? GetMainId(){
			return this.mainId_;
		}
		
		public void SetMainId(long? value){
			this.mainId_ = value;
		}
		public byte? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(byte? value){
			this.status_ = value;
		}
		public string GetAuditdesc(){
			return this.auditdesc_;
		}
		
		public void SetAuditdesc(string value){
			this.auditdesc_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public string GetDataAreaName(){
			return this.dataAreaName_;
		}
		
		public void SetDataAreaName(string value){
			this.dataAreaName_ = value;
		}
		public string GetUserNickName(){
			return this.userNickName_;
		}
		
		public void SetUserNickName(string value){
			this.userNickName_ = value;
		}
		public long? GetUpdateTime(){
			return this.updateTime_;
		}
		
		public void SetUpdateTime(long? value){
			this.updateTime_ = value;
		}
		public long? GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(long? value){
			this.createTime_ = value;
		}
		
	}
	
}