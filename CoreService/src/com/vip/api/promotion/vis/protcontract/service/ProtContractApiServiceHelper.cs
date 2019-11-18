using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	public class ProtContractApiServiceHelper {
		
		
		
		public class addAttachment_args {
			
			///<summary>
			/// 提交确认函附件列表参数
			///</summary>
			
			private List<com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentParams> protContractAttachmentParams_;
			
			public List<com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentParams> GetProtContractAttachmentParams(){
				return this.protContractAttachmentParams_;
			}
			
			public void SetProtContractAttachmentParams(List<com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentParams> value){
				this.protContractAttachmentParams_ = value;
			}
			
		}
		
		
		
		
		public class addProtContract_args {
			
			///<summary>
			/// 新增确认函参数
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParams protContractMainInfoParams_;
			
			///<summary>
			/// 新增确认函力度参数
			///</summary>
			
			private List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams> protContractDiscountInfoParams_;
			
			///<summary>
			/// 操作人信息
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.OperatorParams operatorParams_;
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParams GetProtContractMainInfoParams(){
				return this.protContractMainInfoParams_;
			}
			
			public void SetProtContractMainInfoParams(com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParams value){
				this.protContractMainInfoParams_ = value;
			}
			public List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams> GetProtContractDiscountInfoParams(){
				return this.protContractDiscountInfoParams_;
			}
			
			public void SetProtContractDiscountInfoParams(List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams> value){
				this.protContractDiscountInfoParams_ = value;
			}
			public com.vip.api.promotion.vis.protcontract.service.OperatorParams GetOperatorParams(){
				return this.operatorParams_;
			}
			
			public void SetOperatorParams(com.vip.api.promotion.vis.protcontract.service.OperatorParams value){
				this.operatorParams_ = value;
			}
			
		}
		
		
		
		
		public class auditProtContract_args {
			
			///<summary>
			/// 确认函审批参数
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractAuditParams protContractAuditParams_;
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractAuditParams GetProtContractAuditParams(){
				return this.protContractAuditParams_;
			}
			
			public void SetProtContractAuditParams(com.vip.api.promotion.vis.protcontract.service.ProtContractAuditParams value){
				this.protContractAuditParams_ = value;
			}
			
		}
		
		
		
		
		public class batchGetProtContractDetail_args {
			
			///<summary>
			/// 确认函批量查询参数
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailParam batchProtContractDetailParam_;
			
			public com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailParam GetBatchProtContractDetailParam(){
				return this.batchProtContractDetailParam_;
			}
			
			public void SetBatchProtContractDetailParam(com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailParam value){
				this.batchProtContractDetailParam_ = value;
			}
			
		}
		
		
		
		
		public class checkBinding_args {
			
			///<summary>
			/// 确认函id
			///</summary>
			
			private long? id_;
			
			public long? GetId(){
				return this.id_;
			}
			
			public void SetId(long? value){
				this.id_ = value;
			}
			
		}
		
		
		
		
		public class checkVendorCaptchaActive_args {
			
			///<summary>
			/// 获取验证码参数
			///</summary>
			
			private int? vendorCode_;
			
			public int? GetVendorCode(){
				return this.vendorCode_;
			}
			
			public void SetVendorCode(int? value){
				this.vendorCode_ = value;
			}
			
		}
		
		
		
		
		public class deleteAttachment_args {
			
			///<summary>
			/// 删除确认函附件id
			///</summary>
			
			private long? id_;
			
			///<summary>
			/// 操作人
			///</summary>
			
			private string userEmail_;
			
			public long? GetId(){
				return this.id_;
			}
			
			public void SetId(long? value){
				this.id_ = value;
			}
			public string GetUserEmail(){
				return this.userEmail_;
			}
			
			public void SetUserEmail(string value){
				this.userEmail_ = value;
			}
			
		}
		
		
		
		
		public class deleteProtContract_args {
			
			///<summary>
			/// 删除确认函id
			///</summary>
			
			private long? id_;
			
			///<summary>
			/// 操作人信息
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.OperatorParams operatorParams_;
			
			public long? GetId(){
				return this.id_;
			}
			
			public void SetId(long? value){
				this.id_ = value;
			}
			public com.vip.api.promotion.vis.protcontract.service.OperatorParams GetOperatorParams(){
				return this.operatorParams_;
			}
			
			public void SetOperatorParams(com.vip.api.promotion.vis.protcontract.service.OperatorParams value){
				this.operatorParams_ = value;
			}
			
		}
		
		
		
		
		public class exportCommodityList_args {
			
			///<summary>
			/// 查询活动编号名称列表参数
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.QueryActDetailParam queryActParam_;
			
			public com.vip.api.promotion.vis.protcontract.service.QueryActDetailParam GetQueryActParam(){
				return this.queryActParam_;
			}
			
			public void SetQueryActParam(com.vip.api.promotion.vis.protcontract.service.QueryActDetailParam value){
				this.queryActParam_ = value;
			}
			
		}
		
		
		
		
		public class exportProtContract_args {
			
			///<summary>
			/// 导出确认函列表参数
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParam protContractQueryForAuditParam_;
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParam GetProtContractQueryForAuditParam(){
				return this.protContractQueryForAuditParam_;
			}
			
			public void SetProtContractQueryForAuditParam(com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParam value){
				this.protContractQueryForAuditParam_ = value;
			}
			
		}
		
		
		
		
		public class fetchReminderJobSchedule_args {
			
			
		}
		
		
		
		
		public class getAttachmentCount_args {
			
			///<summary>
			/// 确认函id
			///</summary>
			
			private long? mainId_;
			
			public long? GetMainId(){
				return this.mainId_;
			}
			
			public void SetMainId(long? value){
				this.mainId_ = value;
			}
			
		}
		
		
		
		
		public class getAttachmentList_args {
			
			///<summary>
			/// 确认函id
			///</summary>
			
			private long? mainId_;
			
			public long? GetMainId(){
				return this.mainId_;
			}
			
			public void SetMainId(long? value){
				this.mainId_ = value;
			}
			
		}
		
		
		
		
		public class getBrandGoodsList_args {
			
			///<summary>
			/// 确认函ID参数
			///</summary>
			
			private long? protId_;
			
			public long? GetProtId(){
				return this.protId_;
			}
			
			public void SetProtId(long? value){
				this.protId_ = value;
			}
			
		}
		
		
		
		
		public class getCaptcha_args {
			
			///<summary>
			/// 获取验证码参数
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.GetCaptchaParam getCaptchaParam_;
			
			public com.vip.api.promotion.vis.protcontract.service.GetCaptchaParam GetGetCaptchaParam(){
				return this.getCaptchaParam_;
			}
			
			public void SetGetCaptchaParam(com.vip.api.promotion.vis.protcontract.service.GetCaptchaParam value){
				this.getCaptchaParam_ = value;
			}
			
		}
		
		
		
		
		public class getContractPage_args {
			
			///<summary>
			/// 确认函查询参数
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractQueryParam protContractQueryParam_;
			
			///<summary>
			/// 分页参数
			///</summary>
			
			private com.vip.api.promotion.vis.common.Pager pager_;
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractQueryParam GetProtContractQueryParam(){
				return this.protContractQueryParam_;
			}
			
			public void SetProtContractQueryParam(com.vip.api.promotion.vis.protcontract.service.ProtContractQueryParam value){
				this.protContractQueryParam_ = value;
			}
			public com.vip.api.promotion.vis.common.Pager GetPager(){
				return this.pager_;
			}
			
			public void SetPager(com.vip.api.promotion.vis.common.Pager value){
				this.pager_ = value;
			}
			
		}
		
		
		
		
		public class getContractPageForAudit_args {
			
			///<summary>
			/// 确认函审核列表查询参数
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParam protContractQueryForAuditParam_;
			
			///<summary>
			/// 分页参数
			///</summary>
			
			private com.vip.api.promotion.vis.common.Pager pager_;
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParam GetProtContractQueryForAuditParam(){
				return this.protContractQueryForAuditParam_;
			}
			
			public void SetProtContractQueryForAuditParam(com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParam value){
				this.protContractQueryForAuditParam_ = value;
			}
			public com.vip.api.promotion.vis.common.Pager GetPager(){
				return this.pager_;
			}
			
			public void SetPager(com.vip.api.promotion.vis.common.Pager value){
				this.pager_ = value;
			}
			
		}
		
		
		
		
		public class getProtContractDetail_args {
			
			///<summary>
			/// 确认函查询参数
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractDetailParam protContractDetailParam_;
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractDetailParam GetProtContractDetailParam(){
				return this.protContractDetailParam_;
			}
			
			public void SetProtContractDetailParam(com.vip.api.promotion.vis.protcontract.service.ProtContractDetailParam value){
				this.protContractDetailParam_ = value;
			}
			
		}
		
		
		
		
		public class getProtContractDetailPage_args {
			
			///<summary>
			/// 确认函查询参数
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractDetailQueryParams protContractDetailQueryParams_;
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractDetailQueryParams GetProtContractDetailQueryParams(){
				return this.protContractDetailQueryParams_;
			}
			
			public void SetProtContractDetailQueryParams(com.vip.api.promotion.vis.protcontract.service.ProtContractDetailQueryParams value){
				this.protContractDetailQueryParams_ = value;
			}
			
		}
		
		
		
		
		public class getProtContractView_args {
			
			///<summary>
			/// 确认函id
			///</summary>
			
			private long? mainId_;
			
			public long? GetMainId(){
				return this.mainId_;
			}
			
			public void SetMainId(long? value){
				this.mainId_ = value;
			}
			
		}
		
		
		
		
		public class getVendorsByProtNos_args {
			
			///<summary>
			/// 确认函编号参数
			///</summary>
			
			private List<string> protNos_;
			
			public List<string> GetProtNos(){
				return this.protNos_;
			}
			
			public void SetProtNos(List<string> value){
				this.protNos_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class protContractLimitCheckVendorCodeInBlankList_args {
			
			///<summary>
			/// 确认函批量查询参数
			///</summary>
			
			private string vendorCode_;
			
			public string GetVendorCode(){
				return this.vendorCode_;
			}
			
			public void SetVendorCode(string value){
				this.vendorCode_ = value;
			}
			
		}
		
		
		
		
		public class queryActByActNo_args {
			
			///<summary>
			/// 查询活动编号名称列表参数
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.QueryActParam queryActParam_;
			
			public com.vip.api.promotion.vis.protcontract.service.QueryActParam GetQueryActParam(){
				return this.queryActParam_;
			}
			
			public void SetQueryActParam(com.vip.api.promotion.vis.protcontract.service.QueryActParam value){
				this.queryActParam_ = value;
			}
			
		}
		
		
		
		
		public class queryActDetailByActNo_args {
			
			///<summary>
			/// 查询活动编号名称列表参数
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.QueryActDetailParam queryActParam_;
			
			public com.vip.api.promotion.vis.protcontract.service.QueryActDetailParam GetQueryActParam(){
				return this.queryActParam_;
			}
			
			public void SetQueryActParam(com.vip.api.promotion.vis.protcontract.service.QueryActDetailParam value){
				this.queryActParam_ = value;
			}
			
		}
		
		
		
		
		public class querySpecialName_args {
			
			///<summary>
			/// 专场名称查询条件
			///</summary>
			
			private com.vip.api.promotion.vis.third.service.QueryParam queryParam_;
			
			public com.vip.api.promotion.vis.third.service.QueryParam GetQueryParam(){
				return this.queryParam_;
			}
			
			public void SetQueryParam(com.vip.api.promotion.vis.third.service.QueryParam value){
				this.queryParam_ = value;
			}
			
		}
		
		
		
		
		public class saveProtContractView_args {
			
			///<summary>
			/// 保存确认函页面参数
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractViewSaveParams protContractViewSaveParams_;
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractViewSaveParams GetProtContractViewSaveParams(){
				return this.protContractViewSaveParams_;
			}
			
			public void SetProtContractViewSaveParams(com.vip.api.promotion.vis.protcontract.service.ProtContractViewSaveParams value){
				this.protContractViewSaveParams_ = value;
			}
			
		}
		
		
		
		
		public class searchSalesName_args {
			
			///<summary>
			/// 确认函专场名称参数
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameParam protContractSalesNameParam_;
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameParam GetProtContractSalesNameParam(){
				return this.protContractSalesNameParam_;
			}
			
			public void SetProtContractSalesNameParam(com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameParam value){
				this.protContractSalesNameParam_ = value;
			}
			
		}
		
		
		
		
		public class setApps_args {
			
			///<summary>
			/// 确认函编号
			///</summary>
			
			private long? mainId_;
			
			///<summary>
			/// 多APP值
			///</summary>
			
			private List<string> appValue_;
			
			public long? GetMainId(){
				return this.mainId_;
			}
			
			public void SetMainId(long? value){
				this.mainId_ = value;
			}
			public List<string> GetAppValue(){
				return this.appValue_;
			}
			
			public void SetAppValue(List<string> value){
				this.appValue_ = value;
			}
			
		}
		
		
		
		
		public class submitProtContract_args {
			
			///<summary>
			/// 确认函提交参数
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractSubmitParam protContractSubmitParam_;
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractSubmitParam GetProtContractSubmitParam(){
				return this.protContractSubmitParam_;
			}
			
			public void SetProtContractSubmitParam(com.vip.api.promotion.vis.protcontract.service.ProtContractSubmitParam value){
				this.protContractSubmitParam_ = value;
			}
			
		}
		
		
		
		
		public class updateProtContract_args {
			
			///<summary>
			/// 编辑确认函参数
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParams protContractMainInfoParams_;
			
			///<summary>
			/// 编辑确认函力度参数
			///</summary>
			
			private List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams> protContractDiscountInfoParams_;
			
			///<summary>
			/// 操作人信息
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.OperatorParams operatorParams_;
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParams GetProtContractMainInfoParams(){
				return this.protContractMainInfoParams_;
			}
			
			public void SetProtContractMainInfoParams(com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParams value){
				this.protContractMainInfoParams_ = value;
			}
			public List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams> GetProtContractDiscountInfoParams(){
				return this.protContractDiscountInfoParams_;
			}
			
			public void SetProtContractDiscountInfoParams(List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams> value){
				this.protContractDiscountInfoParams_ = value;
			}
			public com.vip.api.promotion.vis.protcontract.service.OperatorParams GetOperatorParams(){
				return this.operatorParams_;
			}
			
			public void SetOperatorParams(com.vip.api.promotion.vis.protcontract.service.OperatorParams value){
				this.operatorParams_ = value;
			}
			
		}
		
		
		
		
		public class addAttachment_result {
			
			///<summary>
			/// 提交确认函附件结果
			///</summary>
			
			private com.vip.api.promotion.vis.common.ResultModel success_;
			
			public com.vip.api.promotion.vis.common.ResultModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.common.ResultModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class addProtContract_result {
			
			///<summary>
			/// 新增确认函id
			///</summary>
			
			private long? success_;
			
			public long? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(long? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class auditProtContract_result {
			
			///<summary>
			/// 审批确认函结果
			///</summary>
			
			private com.vip.api.promotion.vis.common.ResultModel success_;
			
			public com.vip.api.promotion.vis.common.ResultModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.common.ResultModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class batchGetProtContractDetail_result {
			
			///<summary>
			/// 符合条件的确认函详情列表
			///</summary>
			
			private List<com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailModel> success_;
			
			public List<com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailModel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailModel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class checkBinding_result {
			
			///<summary>
			/// 确认函是否被促销活动绑定结果（0：未绑定，1：活动绑定，2：优惠券绑定）
			///</summary>
			
			private byte? success_;
			
			public byte? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(byte? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class checkVendorCaptchaActive_result {
			
			///<summary>
			/// 供应商是否支持确认函验证码，支持时包含供应商联系邮箱与电话
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.VendorCaptchaActiveModel success_;
			
			public com.vip.api.promotion.vis.protcontract.service.VendorCaptchaActiveModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.protcontract.service.VendorCaptchaActiveModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class deleteAttachment_result {
			
			///<summary>
			/// 删除确认函附件结果
			///</summary>
			
			private com.vip.api.promotion.vis.common.ResultModel success_;
			
			public com.vip.api.promotion.vis.common.ResultModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.common.ResultModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class deleteProtContract_result {
			
			///<summary>
			/// 删除确认函结果
			///</summary>
			
			private com.vip.api.promotion.vis.common.ResultModel success_;
			
			public com.vip.api.promotion.vis.common.ResultModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.common.ResultModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class exportCommodityList_result {
			
			///<summary>
			/// 文件全局的唯一标识fid
			///</summary>
			
			private com.vip.api.promotion.vis.common.FileFid success_;
			
			public com.vip.api.promotion.vis.common.FileFid GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.common.FileFid value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class exportProtContract_result {
			
			///<summary>
			/// 文件全局的唯一标识fid
			///</summary>
			
			private com.vip.api.promotion.vis.common.FileFid success_;
			
			public com.vip.api.promotion.vis.common.FileFid GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.common.FileFid value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class fetchReminderJobSchedule_result {
			
			///<summary>
			/// 定时任务结果返回体
			///</summary>
			
			private com.vip.api.promotion.vis.common.TimedTaskResultModel success_;
			
			public com.vip.api.promotion.vis.common.TimedTaskResultModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.common.TimedTaskResultModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getAttachmentCount_result {
			
			///<summary>
			/// 确认函附件数量
			///</summary>
			
			private int? success_;
			
			public int? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(int? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getAttachmentList_result {
			
			///<summary>
			/// 确认函附件列表
			///</summary>
			
			private List<com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentModel> success_;
			
			public List<com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentModel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentModel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getBrandGoodsList_result {
			
			///<summary>
			/// 品牌承担列表
			///</summary>
			
			private List<com.vip.api.promotion.vis.protcontract.service.BrandGoods> success_;
			
			public List<com.vip.api.promotion.vis.protcontract.service.BrandGoods> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.api.promotion.vis.protcontract.service.BrandGoods> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getCaptcha_result {
			
			///<summary>
			/// 获取验证码
			///</summary>
			
			private com.vip.api.promotion.vis.common.ResultModel success_;
			
			public com.vip.api.promotion.vis.common.ResultModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.common.ResultModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getContractPage_result {
			
			///<summary>
			/// 符合条件的确认函分页
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractPageModel success_;
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractPageModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.protcontract.service.ProtContractPageModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getContractPageForAudit_result {
			
			///<summary>
			/// 符合条件的确认函审核列表分页
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractPageModel success_;
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractPageModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.protcontract.service.ProtContractPageModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getProtContractDetail_result {
			
			///<summary>
			/// 符合条件的确认函详情
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractDetailModel success_;
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractDetailModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.protcontract.service.ProtContractDetailModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getProtContractDetailPage_result {
			
			///<summary>
			/// 确认函详情信息分页
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractDetailPageModel success_;
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractDetailPageModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.protcontract.service.ProtContractDetailPageModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getProtContractView_result {
			
			///<summary>
			/// 确认函页面
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractViewModel success_;
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractViewModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.protcontract.service.ProtContractViewModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getVendorsByProtNos_result {
			
			///<summary>
			/// 供应商列表
			///</summary>
			
			private List<com.vip.api.promotion.vis.protcontract.service.VendorInfoModel> success_;
			
			public List<com.vip.api.promotion.vis.protcontract.service.VendorInfoModel> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.api.promotion.vis.protcontract.service.VendorInfoModel> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_result {
			
			///<summary>
			///</summary>
			
			private com.vip.hermes.core.health.CheckResult success_;
			
			public com.vip.hermes.core.health.CheckResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.hermes.core.health.CheckResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class protContractLimitCheckVendorCodeInBlankList_result {
			
			///<summary>
			/// 确认函限制优化判断供应商是否在白名单中
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryActByActNo_result {
			
			///<summary>
			/// 活动编号名称列表
			///</summary>
			
			private List<com.vip.api.promotion.vis.common.NameValueItem> success_;
			
			public List<com.vip.api.promotion.vis.common.NameValueItem> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<com.vip.api.promotion.vis.common.NameValueItem> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryActDetailByActNo_result {
			
			///<summary>
			/// 活动信息
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.ActivityModel success_;
			
			public com.vip.api.promotion.vis.protcontract.service.ActivityModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.protcontract.service.ActivityModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class querySpecialName_result {
			
			///<summary>
			/// 专场名称列表
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.SpecialNameListModel success_;
			
			public com.vip.api.promotion.vis.protcontract.service.SpecialNameListModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.protcontract.service.SpecialNameListModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class saveProtContractView_result {
			
			///<summary>
			/// 保存确认函页面结果
			///</summary>
			
			private com.vip.api.promotion.vis.common.ResultModel success_;
			
			public com.vip.api.promotion.vis.common.ResultModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.common.ResultModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class searchSalesName_result {
			
			///<summary>
			/// 确认函专场名称查询结果
			///</summary>
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameResultModel success_;
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameResultModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameResultModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class setApps_result {
			
			///<summary>
			/// 操作结果
			///</summary>
			
			private com.vip.api.promotion.vis.common.ResultModel success_;
			
			public com.vip.api.promotion.vis.common.ResultModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.common.ResultModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class submitProtContract_result {
			
			///<summary>
			/// 提交确认函结果
			///</summary>
			
			private com.vip.api.promotion.vis.common.ResultModel success_;
			
			public com.vip.api.promotion.vis.common.ResultModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.common.ResultModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class updateProtContract_result {
			
			///<summary>
			/// 编辑确认函结果
			///</summary>
			
			private com.vip.api.promotion.vis.common.ResultModel success_;
			
			public com.vip.api.promotion.vis.common.ResultModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.api.promotion.vis.common.ResultModel value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class addAttachment_argsHelper : TBeanSerializer<addAttachment_args>
		{
			
			public static addAttachment_argsHelper OBJ = new addAttachment_argsHelper();
			
			public static addAttachment_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addAttachment_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentParams> value;
					
					value = new List<com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentParams>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentParams elem0;
							
							elem0 = new com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentParams();
							com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentParamsHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetProtContractAttachmentParams(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addAttachment_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProtContractAttachmentParams() != null) {
					
					oprot.WriteFieldBegin("protContractAttachmentParams");
					
					oprot.WriteListBegin();
					foreach(com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentParams _item0 in structs.GetProtContractAttachmentParams()){
						
						
						com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentParamsHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("protContractAttachmentParams can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addAttachment_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addProtContract_argsHelper : TBeanSerializer<addProtContract_args>
		{
			
			public static addProtContract_argsHelper OBJ = new addProtContract_argsHelper();
			
			public static addProtContract_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addProtContract_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParams value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParams();
					com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParamsHelper.getInstance().Read(value, iprot);
					
					structs.SetProtContractMainInfoParams(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams> value;
					
					value = new List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams elem2;
							
							elem2 = new com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams();
							com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParamsHelper.getInstance().Read(elem2, iprot);
							
							value.Add(elem2);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetProtContractDiscountInfoParams(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.OperatorParams value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.OperatorParams();
					com.vip.api.promotion.vis.protcontract.service.OperatorParamsHelper.getInstance().Read(value, iprot);
					
					structs.SetOperatorParams(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addProtContract_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProtContractMainInfoParams() != null) {
					
					oprot.WriteFieldBegin("protContractMainInfoParams");
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParamsHelper.getInstance().Write(structs.GetProtContractMainInfoParams(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("protContractMainInfoParams can not be null!");
				}
				
				
				if(structs.GetProtContractDiscountInfoParams() != null) {
					
					oprot.WriteFieldBegin("protContractDiscountInfoParams");
					
					oprot.WriteListBegin();
					foreach(com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams _item0 in structs.GetProtContractDiscountInfoParams()){
						
						
						com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParamsHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("protContractDiscountInfoParams can not be null!");
				}
				
				
				if(structs.GetOperatorParams() != null) {
					
					oprot.WriteFieldBegin("operatorParams");
					
					com.vip.api.promotion.vis.protcontract.service.OperatorParamsHelper.getInstance().Write(structs.GetOperatorParams(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("operatorParams can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addProtContract_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class auditProtContract_argsHelper : TBeanSerializer<auditProtContract_args>
		{
			
			public static auditProtContract_argsHelper OBJ = new auditProtContract_argsHelper();
			
			public static auditProtContract_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(auditProtContract_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractAuditParams value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.ProtContractAuditParams();
					com.vip.api.promotion.vis.protcontract.service.ProtContractAuditParamsHelper.getInstance().Read(value, iprot);
					
					structs.SetProtContractAuditParams(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(auditProtContract_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProtContractAuditParams() != null) {
					
					oprot.WriteFieldBegin("protContractAuditParams");
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractAuditParamsHelper.getInstance().Write(structs.GetProtContractAuditParams(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("protContractAuditParams can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(auditProtContract_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchGetProtContractDetail_argsHelper : TBeanSerializer<batchGetProtContractDetail_args>
		{
			
			public static batchGetProtContractDetail_argsHelper OBJ = new batchGetProtContractDetail_argsHelper();
			
			public static batchGetProtContractDetail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchGetProtContractDetail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailParam value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailParam();
					com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailParamHelper.getInstance().Read(value, iprot);
					
					structs.SetBatchProtContractDetailParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchGetProtContractDetail_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetBatchProtContractDetailParam() != null) {
					
					oprot.WriteFieldBegin("batchProtContractDetailParam");
					
					com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailParamHelper.getInstance().Write(structs.GetBatchProtContractDetailParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("batchProtContractDetailParam can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchGetProtContractDetail_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class checkBinding_argsHelper : TBeanSerializer<checkBinding_args>
		{
			
			public static checkBinding_argsHelper OBJ = new checkBinding_argsHelper();
			
			public static checkBinding_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(checkBinding_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(checkBinding_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetId() != null) {
					
					oprot.WriteFieldBegin("id");
					oprot.WriteI64((long)structs.GetId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("id can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(checkBinding_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class checkVendorCaptchaActive_argsHelper : TBeanSerializer<checkVendorCaptchaActive_args>
		{
			
			public static checkVendorCaptchaActive_argsHelper OBJ = new checkVendorCaptchaActive_argsHelper();
			
			public static checkVendorCaptchaActive_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(checkVendorCaptchaActive_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetVendorCode(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(checkVendorCaptchaActive_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetVendorCode() != null) {
					
					oprot.WriteFieldBegin("vendorCode");
					oprot.WriteI32((int)structs.GetVendorCode()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("vendorCode can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(checkVendorCaptchaActive_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteAttachment_argsHelper : TBeanSerializer<deleteAttachment_args>
		{
			
			public static deleteAttachment_argsHelper OBJ = new deleteAttachment_argsHelper();
			
			public static deleteAttachment_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteAttachment_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetId(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetUserEmail(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteAttachment_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetId() != null) {
					
					oprot.WriteFieldBegin("id");
					oprot.WriteI64((long)structs.GetId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("id can not be null!");
				}
				
				
				if(structs.GetUserEmail() != null) {
					
					oprot.WriteFieldBegin("userEmail");
					oprot.WriteString(structs.GetUserEmail());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("userEmail can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteAttachment_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteProtContract_argsHelper : TBeanSerializer<deleteProtContract_args>
		{
			
			public static deleteProtContract_argsHelper OBJ = new deleteProtContract_argsHelper();
			
			public static deleteProtContract_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteProtContract_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetId(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.OperatorParams value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.OperatorParams();
					com.vip.api.promotion.vis.protcontract.service.OperatorParamsHelper.getInstance().Read(value, iprot);
					
					structs.SetOperatorParams(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteProtContract_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetId() != null) {
					
					oprot.WriteFieldBegin("id");
					oprot.WriteI64((long)structs.GetId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("id can not be null!");
				}
				
				
				if(structs.GetOperatorParams() != null) {
					
					oprot.WriteFieldBegin("operatorParams");
					
					com.vip.api.promotion.vis.protcontract.service.OperatorParamsHelper.getInstance().Write(structs.GetOperatorParams(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("operatorParams can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteProtContract_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class exportCommodityList_argsHelper : TBeanSerializer<exportCommodityList_args>
		{
			
			public static exportCommodityList_argsHelper OBJ = new exportCommodityList_argsHelper();
			
			public static exportCommodityList_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(exportCommodityList_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.QueryActDetailParam value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.QueryActDetailParam();
					com.vip.api.promotion.vis.protcontract.service.QueryActDetailParamHelper.getInstance().Read(value, iprot);
					
					structs.SetQueryActParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(exportCommodityList_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetQueryActParam() != null) {
					
					oprot.WriteFieldBegin("queryActParam");
					
					com.vip.api.promotion.vis.protcontract.service.QueryActDetailParamHelper.getInstance().Write(structs.GetQueryActParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("queryActParam can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(exportCommodityList_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class exportProtContract_argsHelper : TBeanSerializer<exportProtContract_args>
		{
			
			public static exportProtContract_argsHelper OBJ = new exportProtContract_argsHelper();
			
			public static exportProtContract_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(exportProtContract_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParam value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParam();
					com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParamHelper.getInstance().Read(value, iprot);
					
					structs.SetProtContractQueryForAuditParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(exportProtContract_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProtContractQueryForAuditParam() != null) {
					
					oprot.WriteFieldBegin("protContractQueryForAuditParam");
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParamHelper.getInstance().Write(structs.GetProtContractQueryForAuditParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("protContractQueryForAuditParam can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(exportProtContract_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class fetchReminderJobSchedule_argsHelper : TBeanSerializer<fetchReminderJobSchedule_args>
		{
			
			public static fetchReminderJobSchedule_argsHelper OBJ = new fetchReminderJobSchedule_argsHelper();
			
			public static fetchReminderJobSchedule_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(fetchReminderJobSchedule_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(fetchReminderJobSchedule_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(fetchReminderJobSchedule_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getAttachmentCount_argsHelper : TBeanSerializer<getAttachmentCount_args>
		{
			
			public static getAttachmentCount_argsHelper OBJ = new getAttachmentCount_argsHelper();
			
			public static getAttachmentCount_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getAttachmentCount_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetMainId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getAttachmentCount_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetMainId() != null) {
					
					oprot.WriteFieldBegin("mainId");
					oprot.WriteI64((long)structs.GetMainId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("mainId can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getAttachmentCount_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getAttachmentList_argsHelper : TBeanSerializer<getAttachmentList_args>
		{
			
			public static getAttachmentList_argsHelper OBJ = new getAttachmentList_argsHelper();
			
			public static getAttachmentList_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getAttachmentList_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetMainId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getAttachmentList_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetMainId() != null) {
					
					oprot.WriteFieldBegin("mainId");
					oprot.WriteI64((long)structs.GetMainId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("mainId can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getAttachmentList_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getBrandGoodsList_argsHelper : TBeanSerializer<getBrandGoodsList_args>
		{
			
			public static getBrandGoodsList_argsHelper OBJ = new getBrandGoodsList_argsHelper();
			
			public static getBrandGoodsList_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBrandGoodsList_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetProtId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getBrandGoodsList_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProtId() != null) {
					
					oprot.WriteFieldBegin("protId");
					oprot.WriteI64((long)structs.GetProtId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("protId can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBrandGoodsList_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getCaptcha_argsHelper : TBeanSerializer<getCaptcha_args>
		{
			
			public static getCaptcha_argsHelper OBJ = new getCaptcha_argsHelper();
			
			public static getCaptcha_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getCaptcha_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.GetCaptchaParam value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.GetCaptchaParam();
					com.vip.api.promotion.vis.protcontract.service.GetCaptchaParamHelper.getInstance().Read(value, iprot);
					
					structs.SetGetCaptchaParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getCaptcha_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetGetCaptchaParam() != null) {
					
					oprot.WriteFieldBegin("getCaptchaParam");
					
					com.vip.api.promotion.vis.protcontract.service.GetCaptchaParamHelper.getInstance().Write(structs.GetGetCaptchaParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("getCaptchaParam can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getCaptcha_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getContractPage_argsHelper : TBeanSerializer<getContractPage_args>
		{
			
			public static getContractPage_argsHelper OBJ = new getContractPage_argsHelper();
			
			public static getContractPage_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getContractPage_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractQueryParam value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.ProtContractQueryParam();
					com.vip.api.promotion.vis.protcontract.service.ProtContractQueryParamHelper.getInstance().Read(value, iprot);
					
					structs.SetProtContractQueryParam(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.common.Pager value;
					
					value = new com.vip.api.promotion.vis.common.Pager();
					com.vip.api.promotion.vis.common.PagerHelper.getInstance().Read(value, iprot);
					
					structs.SetPager(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getContractPage_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProtContractQueryParam() != null) {
					
					oprot.WriteFieldBegin("protContractQueryParam");
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractQueryParamHelper.getInstance().Write(structs.GetProtContractQueryParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("protContractQueryParam can not be null!");
				}
				
				
				if(structs.GetPager() != null) {
					
					oprot.WriteFieldBegin("pager");
					
					com.vip.api.promotion.vis.common.PagerHelper.getInstance().Write(structs.GetPager(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pager can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getContractPage_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getContractPageForAudit_argsHelper : TBeanSerializer<getContractPageForAudit_args>
		{
			
			public static getContractPageForAudit_argsHelper OBJ = new getContractPageForAudit_argsHelper();
			
			public static getContractPageForAudit_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getContractPageForAudit_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParam value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParam();
					com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParamHelper.getInstance().Read(value, iprot);
					
					structs.SetProtContractQueryForAuditParam(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.common.Pager value;
					
					value = new com.vip.api.promotion.vis.common.Pager();
					com.vip.api.promotion.vis.common.PagerHelper.getInstance().Read(value, iprot);
					
					structs.SetPager(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getContractPageForAudit_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProtContractQueryForAuditParam() != null) {
					
					oprot.WriteFieldBegin("protContractQueryForAuditParam");
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParamHelper.getInstance().Write(structs.GetProtContractQueryForAuditParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("protContractQueryForAuditParam can not be null!");
				}
				
				
				if(structs.GetPager() != null) {
					
					oprot.WriteFieldBegin("pager");
					
					com.vip.api.promotion.vis.common.PagerHelper.getInstance().Write(structs.GetPager(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pager can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getContractPageForAudit_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProtContractDetail_argsHelper : TBeanSerializer<getProtContractDetail_args>
		{
			
			public static getProtContractDetail_argsHelper OBJ = new getProtContractDetail_argsHelper();
			
			public static getProtContractDetail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProtContractDetail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractDetailParam value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.ProtContractDetailParam();
					com.vip.api.promotion.vis.protcontract.service.ProtContractDetailParamHelper.getInstance().Read(value, iprot);
					
					structs.SetProtContractDetailParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProtContractDetail_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProtContractDetailParam() != null) {
					
					oprot.WriteFieldBegin("protContractDetailParam");
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractDetailParamHelper.getInstance().Write(structs.GetProtContractDetailParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("protContractDetailParam can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProtContractDetail_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProtContractDetailPage_argsHelper : TBeanSerializer<getProtContractDetailPage_args>
		{
			
			public static getProtContractDetailPage_argsHelper OBJ = new getProtContractDetailPage_argsHelper();
			
			public static getProtContractDetailPage_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProtContractDetailPage_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractDetailQueryParams value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.ProtContractDetailQueryParams();
					com.vip.api.promotion.vis.protcontract.service.ProtContractDetailQueryParamsHelper.getInstance().Read(value, iprot);
					
					structs.SetProtContractDetailQueryParams(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProtContractDetailPage_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProtContractDetailQueryParams() != null) {
					
					oprot.WriteFieldBegin("protContractDetailQueryParams");
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractDetailQueryParamsHelper.getInstance().Write(structs.GetProtContractDetailQueryParams(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("protContractDetailQueryParams can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProtContractDetailPage_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProtContractView_argsHelper : TBeanSerializer<getProtContractView_args>
		{
			
			public static getProtContractView_argsHelper OBJ = new getProtContractView_argsHelper();
			
			public static getProtContractView_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProtContractView_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetMainId(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProtContractView_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetMainId() != null) {
					
					oprot.WriteFieldBegin("mainId");
					oprot.WriteI64((long)structs.GetMainId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("mainId can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProtContractView_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getVendorsByProtNos_argsHelper : TBeanSerializer<getVendorsByProtNos_args>
		{
			
			public static getVendorsByProtNos_argsHelper OBJ = new getVendorsByProtNos_argsHelper();
			
			public static getVendorsByProtNos_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getVendorsByProtNos_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetProtNos(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getVendorsByProtNos_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProtNos() != null) {
					
					oprot.WriteFieldBegin("protNos");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetProtNos()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("protNos can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getVendorsByProtNos_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_argsHelper : TBeanSerializer<healthCheck_args>
		{
			
			public static healthCheck_argsHelper OBJ = new healthCheck_argsHelper();
			
			public static healthCheck_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class protContractLimitCheckVendorCodeInBlankList_argsHelper : TBeanSerializer<protContractLimitCheckVendorCodeInBlankList_args>
		{
			
			public static protContractLimitCheckVendorCodeInBlankList_argsHelper OBJ = new protContractLimitCheckVendorCodeInBlankList_argsHelper();
			
			public static protContractLimitCheckVendorCodeInBlankList_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(protContractLimitCheckVendorCodeInBlankList_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetVendorCode(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(protContractLimitCheckVendorCodeInBlankList_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetVendorCode() != null) {
					
					oprot.WriteFieldBegin("vendorCode");
					oprot.WriteString(structs.GetVendorCode());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("vendorCode can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(protContractLimitCheckVendorCodeInBlankList_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryActByActNo_argsHelper : TBeanSerializer<queryActByActNo_args>
		{
			
			public static queryActByActNo_argsHelper OBJ = new queryActByActNo_argsHelper();
			
			public static queryActByActNo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryActByActNo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.QueryActParam value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.QueryActParam();
					com.vip.api.promotion.vis.protcontract.service.QueryActParamHelper.getInstance().Read(value, iprot);
					
					structs.SetQueryActParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryActByActNo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetQueryActParam() != null) {
					
					oprot.WriteFieldBegin("queryActParam");
					
					com.vip.api.promotion.vis.protcontract.service.QueryActParamHelper.getInstance().Write(structs.GetQueryActParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("queryActParam can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryActByActNo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryActDetailByActNo_argsHelper : TBeanSerializer<queryActDetailByActNo_args>
		{
			
			public static queryActDetailByActNo_argsHelper OBJ = new queryActDetailByActNo_argsHelper();
			
			public static queryActDetailByActNo_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryActDetailByActNo_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.QueryActDetailParam value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.QueryActDetailParam();
					com.vip.api.promotion.vis.protcontract.service.QueryActDetailParamHelper.getInstance().Read(value, iprot);
					
					structs.SetQueryActParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryActDetailByActNo_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetQueryActParam() != null) {
					
					oprot.WriteFieldBegin("queryActParam");
					
					com.vip.api.promotion.vis.protcontract.service.QueryActDetailParamHelper.getInstance().Write(structs.GetQueryActParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("queryActParam can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryActDetailByActNo_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class querySpecialName_argsHelper : TBeanSerializer<querySpecialName_args>
		{
			
			public static querySpecialName_argsHelper OBJ = new querySpecialName_argsHelper();
			
			public static querySpecialName_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(querySpecialName_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.third.service.QueryParam value;
					
					value = new com.vip.api.promotion.vis.third.service.QueryParam();
					com.vip.api.promotion.vis.third.service.QueryParamHelper.getInstance().Read(value, iprot);
					
					structs.SetQueryParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(querySpecialName_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetQueryParam() != null) {
					
					oprot.WriteFieldBegin("queryParam");
					
					com.vip.api.promotion.vis.third.service.QueryParamHelper.getInstance().Write(structs.GetQueryParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("queryParam can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(querySpecialName_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class saveProtContractView_argsHelper : TBeanSerializer<saveProtContractView_args>
		{
			
			public static saveProtContractView_argsHelper OBJ = new saveProtContractView_argsHelper();
			
			public static saveProtContractView_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(saveProtContractView_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractViewSaveParams value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.ProtContractViewSaveParams();
					com.vip.api.promotion.vis.protcontract.service.ProtContractViewSaveParamsHelper.getInstance().Read(value, iprot);
					
					structs.SetProtContractViewSaveParams(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(saveProtContractView_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProtContractViewSaveParams() != null) {
					
					oprot.WriteFieldBegin("protContractViewSaveParams");
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractViewSaveParamsHelper.getInstance().Write(structs.GetProtContractViewSaveParams(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("protContractViewSaveParams can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(saveProtContractView_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class searchSalesName_argsHelper : TBeanSerializer<searchSalesName_args>
		{
			
			public static searchSalesName_argsHelper OBJ = new searchSalesName_argsHelper();
			
			public static searchSalesName_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(searchSalesName_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameParam value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameParam();
					com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameParamHelper.getInstance().Read(value, iprot);
					
					structs.SetProtContractSalesNameParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(searchSalesName_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProtContractSalesNameParam() != null) {
					
					oprot.WriteFieldBegin("protContractSalesNameParam");
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameParamHelper.getInstance().Write(structs.GetProtContractSalesNameParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("protContractSalesNameParam can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(searchSalesName_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class setApps_argsHelper : TBeanSerializer<setApps_args>
		{
			
			public static setApps_argsHelper OBJ = new setApps_argsHelper();
			
			public static setApps_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(setApps_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long value;
					value = iprot.ReadI64(); 
					
					structs.SetMainId(value);
				}
				
				
				
				
				
				if(true){
					
					List<string> value;
					
					value = new List<string>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							string elem0;
							elem0 = iprot.ReadString();
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetAppValue(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(setApps_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetMainId() != null) {
					
					oprot.WriteFieldBegin("mainId");
					oprot.WriteI64((long)structs.GetMainId()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("mainId can not be null!");
				}
				
				
				if(structs.GetAppValue() != null) {
					
					oprot.WriteFieldBegin("appValue");
					
					oprot.WriteListBegin();
					foreach(string _item0 in structs.GetAppValue()){
						
						oprot.WriteString(_item0);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("appValue can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(setApps_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class submitProtContract_argsHelper : TBeanSerializer<submitProtContract_args>
		{
			
			public static submitProtContract_argsHelper OBJ = new submitProtContract_argsHelper();
			
			public static submitProtContract_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(submitProtContract_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractSubmitParam value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.ProtContractSubmitParam();
					com.vip.api.promotion.vis.protcontract.service.ProtContractSubmitParamHelper.getInstance().Read(value, iprot);
					
					structs.SetProtContractSubmitParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(submitProtContract_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProtContractSubmitParam() != null) {
					
					oprot.WriteFieldBegin("protContractSubmitParam");
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractSubmitParamHelper.getInstance().Write(structs.GetProtContractSubmitParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("protContractSubmitParam can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(submitProtContract_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateProtContract_argsHelper : TBeanSerializer<updateProtContract_args>
		{
			
			public static updateProtContract_argsHelper OBJ = new updateProtContract_argsHelper();
			
			public static updateProtContract_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateProtContract_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParams value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParams();
					com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParamsHelper.getInstance().Read(value, iprot);
					
					structs.SetProtContractMainInfoParams(value);
				}
				
				
				
				
				
				if(true){
					
					List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams> value;
					
					value = new List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams elem1;
							
							elem1 = new com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams();
							com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParamsHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetProtContractDiscountInfoParams(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.OperatorParams value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.OperatorParams();
					com.vip.api.promotion.vis.protcontract.service.OperatorParamsHelper.getInstance().Read(value, iprot);
					
					structs.SetOperatorParams(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateProtContract_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProtContractMainInfoParams() != null) {
					
					oprot.WriteFieldBegin("protContractMainInfoParams");
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParamsHelper.getInstance().Write(structs.GetProtContractMainInfoParams(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("protContractMainInfoParams can not be null!");
				}
				
				
				if(structs.GetProtContractDiscountInfoParams() != null) {
					
					oprot.WriteFieldBegin("protContractDiscountInfoParams");
					
					oprot.WriteListBegin();
					foreach(com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams _item0 in structs.GetProtContractDiscountInfoParams()){
						
						
						com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParamsHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("protContractDiscountInfoParams can not be null!");
				}
				
				
				if(structs.GetOperatorParams() != null) {
					
					oprot.WriteFieldBegin("operatorParams");
					
					com.vip.api.promotion.vis.protcontract.service.OperatorParamsHelper.getInstance().Write(structs.GetOperatorParams(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("operatorParams can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateProtContract_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addAttachment_resultHelper : TBeanSerializer<addAttachment_result>
		{
			
			public static addAttachment_resultHelper OBJ = new addAttachment_resultHelper();
			
			public static addAttachment_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addAttachment_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.common.ResultModel value;
					
					value = new com.vip.api.promotion.vis.common.ResultModel();
					com.vip.api.promotion.vis.common.ResultModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addAttachment_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.common.ResultModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addAttachment_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class addProtContract_resultHelper : TBeanSerializer<addProtContract_result>
		{
			
			public static addProtContract_resultHelper OBJ = new addProtContract_resultHelper();
			
			public static addProtContract_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(addProtContract_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					long? value;
					value = iprot.ReadI64(); 
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(addProtContract_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteI64((long)structs.GetSuccess()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(addProtContract_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class auditProtContract_resultHelper : TBeanSerializer<auditProtContract_result>
		{
			
			public static auditProtContract_resultHelper OBJ = new auditProtContract_resultHelper();
			
			public static auditProtContract_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(auditProtContract_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.common.ResultModel value;
					
					value = new com.vip.api.promotion.vis.common.ResultModel();
					com.vip.api.promotion.vis.common.ResultModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(auditProtContract_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.common.ResultModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(auditProtContract_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchGetProtContractDetail_resultHelper : TBeanSerializer<batchGetProtContractDetail_result>
		{
			
			public static batchGetProtContractDetail_resultHelper OBJ = new batchGetProtContractDetail_resultHelper();
			
			public static batchGetProtContractDetail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchGetProtContractDetail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailModel> value;
					
					value = new List<com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailModel elem0;
							
							elem0 = new com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailModel();
							com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailModelHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchGetProtContractDetail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailModel _item0 in structs.GetSuccess()){
						
						
						com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchGetProtContractDetail_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class checkBinding_resultHelper : TBeanSerializer<checkBinding_result>
		{
			
			public static checkBinding_resultHelper OBJ = new checkBinding_resultHelper();
			
			public static checkBinding_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(checkBinding_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					byte? value;
					value = iprot.ReadByte(); 
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(checkBinding_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteByte((byte)structs.GetSuccess()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(checkBinding_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class checkVendorCaptchaActive_resultHelper : TBeanSerializer<checkVendorCaptchaActive_result>
		{
			
			public static checkVendorCaptchaActive_resultHelper OBJ = new checkVendorCaptchaActive_resultHelper();
			
			public static checkVendorCaptchaActive_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(checkVendorCaptchaActive_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.VendorCaptchaActiveModel value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.VendorCaptchaActiveModel();
					com.vip.api.promotion.vis.protcontract.service.VendorCaptchaActiveModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(checkVendorCaptchaActive_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.protcontract.service.VendorCaptchaActiveModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(checkVendorCaptchaActive_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteAttachment_resultHelper : TBeanSerializer<deleteAttachment_result>
		{
			
			public static deleteAttachment_resultHelper OBJ = new deleteAttachment_resultHelper();
			
			public static deleteAttachment_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteAttachment_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.common.ResultModel value;
					
					value = new com.vip.api.promotion.vis.common.ResultModel();
					com.vip.api.promotion.vis.common.ResultModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteAttachment_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.common.ResultModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteAttachment_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteProtContract_resultHelper : TBeanSerializer<deleteProtContract_result>
		{
			
			public static deleteProtContract_resultHelper OBJ = new deleteProtContract_resultHelper();
			
			public static deleteProtContract_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteProtContract_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.common.ResultModel value;
					
					value = new com.vip.api.promotion.vis.common.ResultModel();
					com.vip.api.promotion.vis.common.ResultModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteProtContract_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.common.ResultModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteProtContract_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class exportCommodityList_resultHelper : TBeanSerializer<exportCommodityList_result>
		{
			
			public static exportCommodityList_resultHelper OBJ = new exportCommodityList_resultHelper();
			
			public static exportCommodityList_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(exportCommodityList_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.common.FileFid value;
					
					value = new com.vip.api.promotion.vis.common.FileFid();
					com.vip.api.promotion.vis.common.FileFidHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(exportCommodityList_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.common.FileFidHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(exportCommodityList_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class exportProtContract_resultHelper : TBeanSerializer<exportProtContract_result>
		{
			
			public static exportProtContract_resultHelper OBJ = new exportProtContract_resultHelper();
			
			public static exportProtContract_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(exportProtContract_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.common.FileFid value;
					
					value = new com.vip.api.promotion.vis.common.FileFid();
					com.vip.api.promotion.vis.common.FileFidHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(exportProtContract_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.common.FileFidHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(exportProtContract_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class fetchReminderJobSchedule_resultHelper : TBeanSerializer<fetchReminderJobSchedule_result>
		{
			
			public static fetchReminderJobSchedule_resultHelper OBJ = new fetchReminderJobSchedule_resultHelper();
			
			public static fetchReminderJobSchedule_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(fetchReminderJobSchedule_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.common.TimedTaskResultModel value;
					
					value = new com.vip.api.promotion.vis.common.TimedTaskResultModel();
					com.vip.api.promotion.vis.common.TimedTaskResultModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(fetchReminderJobSchedule_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.common.TimedTaskResultModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(fetchReminderJobSchedule_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getAttachmentCount_resultHelper : TBeanSerializer<getAttachmentCount_result>
		{
			
			public static getAttachmentCount_resultHelper OBJ = new getAttachmentCount_resultHelper();
			
			public static getAttachmentCount_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getAttachmentCount_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getAttachmentCount_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteI32((int)structs.GetSuccess()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getAttachmentCount_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getAttachmentList_resultHelper : TBeanSerializer<getAttachmentList_result>
		{
			
			public static getAttachmentList_resultHelper OBJ = new getAttachmentList_resultHelper();
			
			public static getAttachmentList_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getAttachmentList_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentModel> value;
					
					value = new List<com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentModel elem0;
							
							elem0 = new com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentModel();
							com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentModelHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getAttachmentList_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentModel _item0 in structs.GetSuccess()){
						
						
						com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getAttachmentList_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getBrandGoodsList_resultHelper : TBeanSerializer<getBrandGoodsList_result>
		{
			
			public static getBrandGoodsList_resultHelper OBJ = new getBrandGoodsList_resultHelper();
			
			public static getBrandGoodsList_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBrandGoodsList_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.api.promotion.vis.protcontract.service.BrandGoods> value;
					
					value = new List<com.vip.api.promotion.vis.protcontract.service.BrandGoods>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.api.promotion.vis.protcontract.service.BrandGoods elem1;
							
							elem1 = new com.vip.api.promotion.vis.protcontract.service.BrandGoods();
							com.vip.api.promotion.vis.protcontract.service.BrandGoodsHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getBrandGoodsList_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.api.promotion.vis.protcontract.service.BrandGoods _item0 in structs.GetSuccess()){
						
						
						com.vip.api.promotion.vis.protcontract.service.BrandGoodsHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBrandGoodsList_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getCaptcha_resultHelper : TBeanSerializer<getCaptcha_result>
		{
			
			public static getCaptcha_resultHelper OBJ = new getCaptcha_resultHelper();
			
			public static getCaptcha_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getCaptcha_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.common.ResultModel value;
					
					value = new com.vip.api.promotion.vis.common.ResultModel();
					com.vip.api.promotion.vis.common.ResultModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getCaptcha_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.common.ResultModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getCaptcha_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getContractPage_resultHelper : TBeanSerializer<getContractPage_result>
		{
			
			public static getContractPage_resultHelper OBJ = new getContractPage_resultHelper();
			
			public static getContractPage_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getContractPage_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractPageModel value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.ProtContractPageModel();
					com.vip.api.promotion.vis.protcontract.service.ProtContractPageModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getContractPage_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractPageModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getContractPage_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getContractPageForAudit_resultHelper : TBeanSerializer<getContractPageForAudit_result>
		{
			
			public static getContractPageForAudit_resultHelper OBJ = new getContractPageForAudit_resultHelper();
			
			public static getContractPageForAudit_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getContractPageForAudit_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractPageModel value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.ProtContractPageModel();
					com.vip.api.promotion.vis.protcontract.service.ProtContractPageModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getContractPageForAudit_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractPageModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getContractPageForAudit_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProtContractDetail_resultHelper : TBeanSerializer<getProtContractDetail_result>
		{
			
			public static getProtContractDetail_resultHelper OBJ = new getProtContractDetail_resultHelper();
			
			public static getProtContractDetail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProtContractDetail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractDetailModel value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.ProtContractDetailModel();
					com.vip.api.promotion.vis.protcontract.service.ProtContractDetailModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProtContractDetail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractDetailModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProtContractDetail_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProtContractDetailPage_resultHelper : TBeanSerializer<getProtContractDetailPage_result>
		{
			
			public static getProtContractDetailPage_resultHelper OBJ = new getProtContractDetailPage_resultHelper();
			
			public static getProtContractDetailPage_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProtContractDetailPage_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractDetailPageModel value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.ProtContractDetailPageModel();
					com.vip.api.promotion.vis.protcontract.service.ProtContractDetailPageModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProtContractDetailPage_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractDetailPageModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProtContractDetailPage_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getProtContractView_resultHelper : TBeanSerializer<getProtContractView_result>
		{
			
			public static getProtContractView_resultHelper OBJ = new getProtContractView_resultHelper();
			
			public static getProtContractView_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getProtContractView_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractViewModel value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.ProtContractViewModel();
					com.vip.api.promotion.vis.protcontract.service.ProtContractViewModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getProtContractView_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractViewModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getProtContractView_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getVendorsByProtNos_resultHelper : TBeanSerializer<getVendorsByProtNos_result>
		{
			
			public static getVendorsByProtNos_resultHelper OBJ = new getVendorsByProtNos_resultHelper();
			
			public static getVendorsByProtNos_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getVendorsByProtNos_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.api.promotion.vis.protcontract.service.VendorInfoModel> value;
					
					value = new List<com.vip.api.promotion.vis.protcontract.service.VendorInfoModel>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.api.promotion.vis.protcontract.service.VendorInfoModel elem0;
							
							elem0 = new com.vip.api.promotion.vis.protcontract.service.VendorInfoModel();
							com.vip.api.promotion.vis.protcontract.service.VendorInfoModelHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getVendorsByProtNos_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.api.promotion.vis.protcontract.service.VendorInfoModel _item0 in structs.GetSuccess()){
						
						
						com.vip.api.promotion.vis.protcontract.service.VendorInfoModelHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getVendorsByProtNos_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_resultHelper : TBeanSerializer<healthCheck_result>
		{
			
			public static healthCheck_resultHelper OBJ = new healthCheck_resultHelper();
			
			public static healthCheck_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.hermes.core.health.CheckResult value;
					
					value = new com.vip.hermes.core.health.CheckResult();
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class protContractLimitCheckVendorCodeInBlankList_resultHelper : TBeanSerializer<protContractLimitCheckVendorCodeInBlankList_result>
		{
			
			public static protContractLimitCheckVendorCodeInBlankList_resultHelper OBJ = new protContractLimitCheckVendorCodeInBlankList_resultHelper();
			
			public static protContractLimitCheckVendorCodeInBlankList_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(protContractLimitCheckVendorCodeInBlankList_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool? value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(protContractLimitCheckVendorCodeInBlankList_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(protContractLimitCheckVendorCodeInBlankList_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryActByActNo_resultHelper : TBeanSerializer<queryActByActNo_result>
		{
			
			public static queryActByActNo_resultHelper OBJ = new queryActByActNo_resultHelper();
			
			public static queryActByActNo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryActByActNo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<com.vip.api.promotion.vis.common.NameValueItem> value;
					
					value = new List<com.vip.api.promotion.vis.common.NameValueItem>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							com.vip.api.promotion.vis.common.NameValueItem elem0;
							
							elem0 = new com.vip.api.promotion.vis.common.NameValueItem();
							com.vip.api.promotion.vis.common.NameValueItemHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryActByActNo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(com.vip.api.promotion.vis.common.NameValueItem _item0 in structs.GetSuccess()){
						
						
						com.vip.api.promotion.vis.common.NameValueItemHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryActByActNo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryActDetailByActNo_resultHelper : TBeanSerializer<queryActDetailByActNo_result>
		{
			
			public static queryActDetailByActNo_resultHelper OBJ = new queryActDetailByActNo_resultHelper();
			
			public static queryActDetailByActNo_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryActDetailByActNo_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.ActivityModel value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.ActivityModel();
					com.vip.api.promotion.vis.protcontract.service.ActivityModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryActDetailByActNo_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.protcontract.service.ActivityModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryActDetailByActNo_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class querySpecialName_resultHelper : TBeanSerializer<querySpecialName_result>
		{
			
			public static querySpecialName_resultHelper OBJ = new querySpecialName_resultHelper();
			
			public static querySpecialName_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(querySpecialName_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.SpecialNameListModel value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.SpecialNameListModel();
					com.vip.api.promotion.vis.protcontract.service.SpecialNameListModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(querySpecialName_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.protcontract.service.SpecialNameListModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(querySpecialName_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class saveProtContractView_resultHelper : TBeanSerializer<saveProtContractView_result>
		{
			
			public static saveProtContractView_resultHelper OBJ = new saveProtContractView_resultHelper();
			
			public static saveProtContractView_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(saveProtContractView_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.common.ResultModel value;
					
					value = new com.vip.api.promotion.vis.common.ResultModel();
					com.vip.api.promotion.vis.common.ResultModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(saveProtContractView_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.common.ResultModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(saveProtContractView_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class searchSalesName_resultHelper : TBeanSerializer<searchSalesName_result>
		{
			
			public static searchSalesName_resultHelper OBJ = new searchSalesName_resultHelper();
			
			public static searchSalesName_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(searchSalesName_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameResultModel value;
					
					value = new com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameResultModel();
					com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameResultModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(searchSalesName_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameResultModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(searchSalesName_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class setApps_resultHelper : TBeanSerializer<setApps_result>
		{
			
			public static setApps_resultHelper OBJ = new setApps_resultHelper();
			
			public static setApps_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(setApps_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.common.ResultModel value;
					
					value = new com.vip.api.promotion.vis.common.ResultModel();
					com.vip.api.promotion.vis.common.ResultModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(setApps_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.common.ResultModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(setApps_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class submitProtContract_resultHelper : TBeanSerializer<submitProtContract_result>
		{
			
			public static submitProtContract_resultHelper OBJ = new submitProtContract_resultHelper();
			
			public static submitProtContract_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(submitProtContract_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.common.ResultModel value;
					
					value = new com.vip.api.promotion.vis.common.ResultModel();
					com.vip.api.promotion.vis.common.ResultModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(submitProtContract_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.common.ResultModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(submitProtContract_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateProtContract_resultHelper : TBeanSerializer<updateProtContract_result>
		{
			
			public static updateProtContract_resultHelper OBJ = new updateProtContract_resultHelper();
			
			public static updateProtContract_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateProtContract_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.api.promotion.vis.common.ResultModel value;
					
					value = new com.vip.api.promotion.vis.common.ResultModel();
					com.vip.api.promotion.vis.common.ResultModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateProtContract_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.api.promotion.vis.common.ResultModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateProtContract_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class ProtContractApiServiceClient : OspRestStub , ProtContractApiService  {
			
			
			public ProtContractApiServiceClient():base("com.vip.api.promotion.vis.protcontract.service.ProtContractApiService","1.1.2") {
				
				
			}
			
			
			
			public com.vip.api.promotion.vis.common.ResultModel addAttachment(List<com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentParams> protContractAttachmentParams_) {
				
				send_addAttachment(protContractAttachmentParams_);
				return recv_addAttachment(); 
				
			}
			
			
			private void send_addAttachment(List<com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentParams> protContractAttachmentParams_){
				
				InitInvocation("addAttachment");
				
				addAttachment_args args = new addAttachment_args();
				args.SetProtContractAttachmentParams(protContractAttachmentParams_);
				
				SendBase(args, addAttachment_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.common.ResultModel recv_addAttachment(){
				
				addAttachment_result result = new addAttachment_result();
				ReceiveBase(result, addAttachment_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public long? addProtContract(com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParams protContractMainInfoParams_,List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams> protContractDiscountInfoParams_,com.vip.api.promotion.vis.protcontract.service.OperatorParams operatorParams_) {
				
				send_addProtContract(protContractMainInfoParams_,protContractDiscountInfoParams_,operatorParams_);
				return recv_addProtContract(); 
				
			}
			
			
			private void send_addProtContract(com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParams protContractMainInfoParams_,List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams> protContractDiscountInfoParams_,com.vip.api.promotion.vis.protcontract.service.OperatorParams operatorParams_){
				
				InitInvocation("addProtContract");
				
				addProtContract_args args = new addProtContract_args();
				args.SetProtContractMainInfoParams(protContractMainInfoParams_);
				args.SetProtContractDiscountInfoParams(protContractDiscountInfoParams_);
				args.SetOperatorParams(operatorParams_);
				
				SendBase(args, addProtContract_argsHelper.getInstance());
			}
			
			
			private long? recv_addProtContract(){
				
				addProtContract_result result = new addProtContract_result();
				ReceiveBase(result, addProtContract_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.common.ResultModel auditProtContract(com.vip.api.promotion.vis.protcontract.service.ProtContractAuditParams protContractAuditParams_) {
				
				send_auditProtContract(protContractAuditParams_);
				return recv_auditProtContract(); 
				
			}
			
			
			private void send_auditProtContract(com.vip.api.promotion.vis.protcontract.service.ProtContractAuditParams protContractAuditParams_){
				
				InitInvocation("auditProtContract");
				
				auditProtContract_args args = new auditProtContract_args();
				args.SetProtContractAuditParams(protContractAuditParams_);
				
				SendBase(args, auditProtContract_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.common.ResultModel recv_auditProtContract(){
				
				auditProtContract_result result = new auditProtContract_result();
				ReceiveBase(result, auditProtContract_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailModel> batchGetProtContractDetail(com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailParam batchProtContractDetailParam_) {
				
				send_batchGetProtContractDetail(batchProtContractDetailParam_);
				return recv_batchGetProtContractDetail(); 
				
			}
			
			
			private void send_batchGetProtContractDetail(com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailParam batchProtContractDetailParam_){
				
				InitInvocation("batchGetProtContractDetail");
				
				batchGetProtContractDetail_args args = new batchGetProtContractDetail_args();
				args.SetBatchProtContractDetailParam(batchProtContractDetailParam_);
				
				SendBase(args, batchGetProtContractDetail_argsHelper.getInstance());
			}
			
			
			private List<com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailModel> recv_batchGetProtContractDetail(){
				
				batchGetProtContractDetail_result result = new batchGetProtContractDetail_result();
				ReceiveBase(result, batchGetProtContractDetail_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public byte? checkBinding(long id_) {
				
				send_checkBinding(id_);
				return recv_checkBinding(); 
				
			}
			
			
			private void send_checkBinding(long id_){
				
				InitInvocation("checkBinding");
				
				checkBinding_args args = new checkBinding_args();
				args.SetId(id_);
				
				SendBase(args, checkBinding_argsHelper.getInstance());
			}
			
			
			private byte? recv_checkBinding(){
				
				checkBinding_result result = new checkBinding_result();
				ReceiveBase(result, checkBinding_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.protcontract.service.VendorCaptchaActiveModel checkVendorCaptchaActive(int vendorCode_) {
				
				send_checkVendorCaptchaActive(vendorCode_);
				return recv_checkVendorCaptchaActive(); 
				
			}
			
			
			private void send_checkVendorCaptchaActive(int vendorCode_){
				
				InitInvocation("checkVendorCaptchaActive");
				
				checkVendorCaptchaActive_args args = new checkVendorCaptchaActive_args();
				args.SetVendorCode(vendorCode_);
				
				SendBase(args, checkVendorCaptchaActive_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.protcontract.service.VendorCaptchaActiveModel recv_checkVendorCaptchaActive(){
				
				checkVendorCaptchaActive_result result = new checkVendorCaptchaActive_result();
				ReceiveBase(result, checkVendorCaptchaActive_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.common.ResultModel deleteAttachment(long id_,string userEmail_) {
				
				send_deleteAttachment(id_,userEmail_);
				return recv_deleteAttachment(); 
				
			}
			
			
			private void send_deleteAttachment(long id_,string userEmail_){
				
				InitInvocation("deleteAttachment");
				
				deleteAttachment_args args = new deleteAttachment_args();
				args.SetId(id_);
				args.SetUserEmail(userEmail_);
				
				SendBase(args, deleteAttachment_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.common.ResultModel recv_deleteAttachment(){
				
				deleteAttachment_result result = new deleteAttachment_result();
				ReceiveBase(result, deleteAttachment_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.common.ResultModel deleteProtContract(long id_,com.vip.api.promotion.vis.protcontract.service.OperatorParams operatorParams_) {
				
				send_deleteProtContract(id_,operatorParams_);
				return recv_deleteProtContract(); 
				
			}
			
			
			private void send_deleteProtContract(long id_,com.vip.api.promotion.vis.protcontract.service.OperatorParams operatorParams_){
				
				InitInvocation("deleteProtContract");
				
				deleteProtContract_args args = new deleteProtContract_args();
				args.SetId(id_);
				args.SetOperatorParams(operatorParams_);
				
				SendBase(args, deleteProtContract_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.common.ResultModel recv_deleteProtContract(){
				
				deleteProtContract_result result = new deleteProtContract_result();
				ReceiveBase(result, deleteProtContract_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.common.FileFid exportCommodityList(com.vip.api.promotion.vis.protcontract.service.QueryActDetailParam queryActParam_) {
				
				send_exportCommodityList(queryActParam_);
				return recv_exportCommodityList(); 
				
			}
			
			
			private void send_exportCommodityList(com.vip.api.promotion.vis.protcontract.service.QueryActDetailParam queryActParam_){
				
				InitInvocation("exportCommodityList");
				
				exportCommodityList_args args = new exportCommodityList_args();
				args.SetQueryActParam(queryActParam_);
				
				SendBase(args, exportCommodityList_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.common.FileFid recv_exportCommodityList(){
				
				exportCommodityList_result result = new exportCommodityList_result();
				ReceiveBase(result, exportCommodityList_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.common.FileFid exportProtContract(com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParam protContractQueryForAuditParam_) {
				
				send_exportProtContract(protContractQueryForAuditParam_);
				return recv_exportProtContract(); 
				
			}
			
			
			private void send_exportProtContract(com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParam protContractQueryForAuditParam_){
				
				InitInvocation("exportProtContract");
				
				exportProtContract_args args = new exportProtContract_args();
				args.SetProtContractQueryForAuditParam(protContractQueryForAuditParam_);
				
				SendBase(args, exportProtContract_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.common.FileFid recv_exportProtContract(){
				
				exportProtContract_result result = new exportProtContract_result();
				ReceiveBase(result, exportProtContract_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.common.TimedTaskResultModel fetchReminderJobSchedule() {
				
				send_fetchReminderJobSchedule();
				return recv_fetchReminderJobSchedule(); 
				
			}
			
			
			private void send_fetchReminderJobSchedule(){
				
				InitInvocation("fetchReminderJobSchedule");
				
				fetchReminderJobSchedule_args args = new fetchReminderJobSchedule_args();
				
				SendBase(args, fetchReminderJobSchedule_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.common.TimedTaskResultModel recv_fetchReminderJobSchedule(){
				
				fetchReminderJobSchedule_result result = new fetchReminderJobSchedule_result();
				ReceiveBase(result, fetchReminderJobSchedule_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public int? getAttachmentCount(long mainId_) {
				
				send_getAttachmentCount(mainId_);
				return recv_getAttachmentCount(); 
				
			}
			
			
			private void send_getAttachmentCount(long mainId_){
				
				InitInvocation("getAttachmentCount");
				
				getAttachmentCount_args args = new getAttachmentCount_args();
				args.SetMainId(mainId_);
				
				SendBase(args, getAttachmentCount_argsHelper.getInstance());
			}
			
			
			private int? recv_getAttachmentCount(){
				
				getAttachmentCount_result result = new getAttachmentCount_result();
				ReceiveBase(result, getAttachmentCount_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentModel> getAttachmentList(long mainId_) {
				
				send_getAttachmentList(mainId_);
				return recv_getAttachmentList(); 
				
			}
			
			
			private void send_getAttachmentList(long mainId_){
				
				InitInvocation("getAttachmentList");
				
				getAttachmentList_args args = new getAttachmentList_args();
				args.SetMainId(mainId_);
				
				SendBase(args, getAttachmentList_argsHelper.getInstance());
			}
			
			
			private List<com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentModel> recv_getAttachmentList(){
				
				getAttachmentList_result result = new getAttachmentList_result();
				ReceiveBase(result, getAttachmentList_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.api.promotion.vis.protcontract.service.BrandGoods> getBrandGoodsList(long protId_) {
				
				send_getBrandGoodsList(protId_);
				return recv_getBrandGoodsList(); 
				
			}
			
			
			private void send_getBrandGoodsList(long protId_){
				
				InitInvocation("getBrandGoodsList");
				
				getBrandGoodsList_args args = new getBrandGoodsList_args();
				args.SetProtId(protId_);
				
				SendBase(args, getBrandGoodsList_argsHelper.getInstance());
			}
			
			
			private List<com.vip.api.promotion.vis.protcontract.service.BrandGoods> recv_getBrandGoodsList(){
				
				getBrandGoodsList_result result = new getBrandGoodsList_result();
				ReceiveBase(result, getBrandGoodsList_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.common.ResultModel getCaptcha(com.vip.api.promotion.vis.protcontract.service.GetCaptchaParam getCaptchaParam_) {
				
				send_getCaptcha(getCaptchaParam_);
				return recv_getCaptcha(); 
				
			}
			
			
			private void send_getCaptcha(com.vip.api.promotion.vis.protcontract.service.GetCaptchaParam getCaptchaParam_){
				
				InitInvocation("getCaptcha");
				
				getCaptcha_args args = new getCaptcha_args();
				args.SetGetCaptchaParam(getCaptchaParam_);
				
				SendBase(args, getCaptcha_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.common.ResultModel recv_getCaptcha(){
				
				getCaptcha_result result = new getCaptcha_result();
				ReceiveBase(result, getCaptcha_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractPageModel getContractPage(com.vip.api.promotion.vis.protcontract.service.ProtContractQueryParam protContractQueryParam_,com.vip.api.promotion.vis.common.Pager pager_) {
				
				send_getContractPage(protContractQueryParam_,pager_);
				return recv_getContractPage(); 
				
			}
			
			
			private void send_getContractPage(com.vip.api.promotion.vis.protcontract.service.ProtContractQueryParam protContractQueryParam_,com.vip.api.promotion.vis.common.Pager pager_){
				
				InitInvocation("getContractPage");
				
				getContractPage_args args = new getContractPage_args();
				args.SetProtContractQueryParam(protContractQueryParam_);
				args.SetPager(pager_);
				
				SendBase(args, getContractPage_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractPageModel recv_getContractPage(){
				
				getContractPage_result result = new getContractPage_result();
				ReceiveBase(result, getContractPage_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractPageModel getContractPageForAudit(com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParam protContractQueryForAuditParam_,com.vip.api.promotion.vis.common.Pager pager_) {
				
				send_getContractPageForAudit(protContractQueryForAuditParam_,pager_);
				return recv_getContractPageForAudit(); 
				
			}
			
			
			private void send_getContractPageForAudit(com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParam protContractQueryForAuditParam_,com.vip.api.promotion.vis.common.Pager pager_){
				
				InitInvocation("getContractPageForAudit");
				
				getContractPageForAudit_args args = new getContractPageForAudit_args();
				args.SetProtContractQueryForAuditParam(protContractQueryForAuditParam_);
				args.SetPager(pager_);
				
				SendBase(args, getContractPageForAudit_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractPageModel recv_getContractPageForAudit(){
				
				getContractPageForAudit_result result = new getContractPageForAudit_result();
				ReceiveBase(result, getContractPageForAudit_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractDetailModel getProtContractDetail(com.vip.api.promotion.vis.protcontract.service.ProtContractDetailParam protContractDetailParam_) {
				
				send_getProtContractDetail(protContractDetailParam_);
				return recv_getProtContractDetail(); 
				
			}
			
			
			private void send_getProtContractDetail(com.vip.api.promotion.vis.protcontract.service.ProtContractDetailParam protContractDetailParam_){
				
				InitInvocation("getProtContractDetail");
				
				getProtContractDetail_args args = new getProtContractDetail_args();
				args.SetProtContractDetailParam(protContractDetailParam_);
				
				SendBase(args, getProtContractDetail_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractDetailModel recv_getProtContractDetail(){
				
				getProtContractDetail_result result = new getProtContractDetail_result();
				ReceiveBase(result, getProtContractDetail_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractDetailPageModel getProtContractDetailPage(com.vip.api.promotion.vis.protcontract.service.ProtContractDetailQueryParams protContractDetailQueryParams_) {
				
				send_getProtContractDetailPage(protContractDetailQueryParams_);
				return recv_getProtContractDetailPage(); 
				
			}
			
			
			private void send_getProtContractDetailPage(com.vip.api.promotion.vis.protcontract.service.ProtContractDetailQueryParams protContractDetailQueryParams_){
				
				InitInvocation("getProtContractDetailPage");
				
				getProtContractDetailPage_args args = new getProtContractDetailPage_args();
				args.SetProtContractDetailQueryParams(protContractDetailQueryParams_);
				
				SendBase(args, getProtContractDetailPage_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractDetailPageModel recv_getProtContractDetailPage(){
				
				getProtContractDetailPage_result result = new getProtContractDetailPage_result();
				ReceiveBase(result, getProtContractDetailPage_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractViewModel getProtContractView(long mainId_) {
				
				send_getProtContractView(mainId_);
				return recv_getProtContractView(); 
				
			}
			
			
			private void send_getProtContractView(long mainId_){
				
				InitInvocation("getProtContractView");
				
				getProtContractView_args args = new getProtContractView_args();
				args.SetMainId(mainId_);
				
				SendBase(args, getProtContractView_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractViewModel recv_getProtContractView(){
				
				getProtContractView_result result = new getProtContractView_result();
				ReceiveBase(result, getProtContractView_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.api.promotion.vis.protcontract.service.VendorInfoModel> getVendorsByProtNos(List<string> protNos_) {
				
				send_getVendorsByProtNos(protNos_);
				return recv_getVendorsByProtNos(); 
				
			}
			
			
			private void send_getVendorsByProtNos(List<string> protNos_){
				
				InitInvocation("getVendorsByProtNos");
				
				getVendorsByProtNos_args args = new getVendorsByProtNos_args();
				args.SetProtNos(protNos_);
				
				SendBase(args, getVendorsByProtNos_argsHelper.getInstance());
			}
			
			
			private List<com.vip.api.promotion.vis.protcontract.service.VendorInfoModel> recv_getVendorsByProtNos(){
				
				getVendorsByProtNos_result result = new getVendorsByProtNos_result();
				ReceiveBase(result, getVendorsByProtNos_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.hermes.core.health.CheckResult healthCheck() {
				
				send_healthCheck();
				return recv_healthCheck(); 
				
			}
			
			
			private void send_healthCheck(){
				
				InitInvocation("healthCheck");
				
				healthCheck_args args = new healthCheck_args();
				
				SendBase(args, healthCheck_argsHelper.getInstance());
			}
			
			
			private com.vip.hermes.core.health.CheckResult recv_healthCheck(){
				
				healthCheck_result result = new healthCheck_result();
				ReceiveBase(result, healthCheck_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? protContractLimitCheckVendorCodeInBlankList(string vendorCode_) {
				
				send_protContractLimitCheckVendorCodeInBlankList(vendorCode_);
				return recv_protContractLimitCheckVendorCodeInBlankList(); 
				
			}
			
			
			private void send_protContractLimitCheckVendorCodeInBlankList(string vendorCode_){
				
				InitInvocation("protContractLimitCheckVendorCodeInBlankList");
				
				protContractLimitCheckVendorCodeInBlankList_args args = new protContractLimitCheckVendorCodeInBlankList_args();
				args.SetVendorCode(vendorCode_);
				
				SendBase(args, protContractLimitCheckVendorCodeInBlankList_argsHelper.getInstance());
			}
			
			
			private bool? recv_protContractLimitCheckVendorCodeInBlankList(){
				
				protContractLimitCheckVendorCodeInBlankList_result result = new protContractLimitCheckVendorCodeInBlankList_result();
				ReceiveBase(result, protContractLimitCheckVendorCodeInBlankList_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<com.vip.api.promotion.vis.common.NameValueItem> queryActByActNo(com.vip.api.promotion.vis.protcontract.service.QueryActParam queryActParam_) {
				
				send_queryActByActNo(queryActParam_);
				return recv_queryActByActNo(); 
				
			}
			
			
			private void send_queryActByActNo(com.vip.api.promotion.vis.protcontract.service.QueryActParam queryActParam_){
				
				InitInvocation("queryActByActNo");
				
				queryActByActNo_args args = new queryActByActNo_args();
				args.SetQueryActParam(queryActParam_);
				
				SendBase(args, queryActByActNo_argsHelper.getInstance());
			}
			
			
			private List<com.vip.api.promotion.vis.common.NameValueItem> recv_queryActByActNo(){
				
				queryActByActNo_result result = new queryActByActNo_result();
				ReceiveBase(result, queryActByActNo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.protcontract.service.ActivityModel queryActDetailByActNo(com.vip.api.promotion.vis.protcontract.service.QueryActDetailParam queryActParam_) {
				
				send_queryActDetailByActNo(queryActParam_);
				return recv_queryActDetailByActNo(); 
				
			}
			
			
			private void send_queryActDetailByActNo(com.vip.api.promotion.vis.protcontract.service.QueryActDetailParam queryActParam_){
				
				InitInvocation("queryActDetailByActNo");
				
				queryActDetailByActNo_args args = new queryActDetailByActNo_args();
				args.SetQueryActParam(queryActParam_);
				
				SendBase(args, queryActDetailByActNo_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.protcontract.service.ActivityModel recv_queryActDetailByActNo(){
				
				queryActDetailByActNo_result result = new queryActDetailByActNo_result();
				ReceiveBase(result, queryActDetailByActNo_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.protcontract.service.SpecialNameListModel querySpecialName(com.vip.api.promotion.vis.third.service.QueryParam queryParam_) {
				
				send_querySpecialName(queryParam_);
				return recv_querySpecialName(); 
				
			}
			
			
			private void send_querySpecialName(com.vip.api.promotion.vis.third.service.QueryParam queryParam_){
				
				InitInvocation("querySpecialName");
				
				querySpecialName_args args = new querySpecialName_args();
				args.SetQueryParam(queryParam_);
				
				SendBase(args, querySpecialName_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.protcontract.service.SpecialNameListModel recv_querySpecialName(){
				
				querySpecialName_result result = new querySpecialName_result();
				ReceiveBase(result, querySpecialName_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.common.ResultModel saveProtContractView(com.vip.api.promotion.vis.protcontract.service.ProtContractViewSaveParams protContractViewSaveParams_) {
				
				send_saveProtContractView(protContractViewSaveParams_);
				return recv_saveProtContractView(); 
				
			}
			
			
			private void send_saveProtContractView(com.vip.api.promotion.vis.protcontract.service.ProtContractViewSaveParams protContractViewSaveParams_){
				
				InitInvocation("saveProtContractView");
				
				saveProtContractView_args args = new saveProtContractView_args();
				args.SetProtContractViewSaveParams(protContractViewSaveParams_);
				
				SendBase(args, saveProtContractView_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.common.ResultModel recv_saveProtContractView(){
				
				saveProtContractView_result result = new saveProtContractView_result();
				ReceiveBase(result, saveProtContractView_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameResultModel searchSalesName(com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameParam protContractSalesNameParam_) {
				
				send_searchSalesName(protContractSalesNameParam_);
				return recv_searchSalesName(); 
				
			}
			
			
			private void send_searchSalesName(com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameParam protContractSalesNameParam_){
				
				InitInvocation("searchSalesName");
				
				searchSalesName_args args = new searchSalesName_args();
				args.SetProtContractSalesNameParam(protContractSalesNameParam_);
				
				SendBase(args, searchSalesName_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameResultModel recv_searchSalesName(){
				
				searchSalesName_result result = new searchSalesName_result();
				ReceiveBase(result, searchSalesName_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.common.ResultModel setApps(long mainId_,List<string> appValue_) {
				
				send_setApps(mainId_,appValue_);
				return recv_setApps(); 
				
			}
			
			
			private void send_setApps(long mainId_,List<string> appValue_){
				
				InitInvocation("setApps");
				
				setApps_args args = new setApps_args();
				args.SetMainId(mainId_);
				args.SetAppValue(appValue_);
				
				SendBase(args, setApps_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.common.ResultModel recv_setApps(){
				
				setApps_result result = new setApps_result();
				ReceiveBase(result, setApps_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.common.ResultModel submitProtContract(com.vip.api.promotion.vis.protcontract.service.ProtContractSubmitParam protContractSubmitParam_) {
				
				send_submitProtContract(protContractSubmitParam_);
				return recv_submitProtContract(); 
				
			}
			
			
			private void send_submitProtContract(com.vip.api.promotion.vis.protcontract.service.ProtContractSubmitParam protContractSubmitParam_){
				
				InitInvocation("submitProtContract");
				
				submitProtContract_args args = new submitProtContract_args();
				args.SetProtContractSubmitParam(protContractSubmitParam_);
				
				SendBase(args, submitProtContract_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.common.ResultModel recv_submitProtContract(){
				
				submitProtContract_result result = new submitProtContract_result();
				ReceiveBase(result, submitProtContract_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.api.promotion.vis.common.ResultModel updateProtContract(com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParams protContractMainInfoParams_,List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams> protContractDiscountInfoParams_,com.vip.api.promotion.vis.protcontract.service.OperatorParams operatorParams_) {
				
				send_updateProtContract(protContractMainInfoParams_,protContractDiscountInfoParams_,operatorParams_);
				return recv_updateProtContract(); 
				
			}
			
			
			private void send_updateProtContract(com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParams protContractMainInfoParams_,List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams> protContractDiscountInfoParams_,com.vip.api.promotion.vis.protcontract.service.OperatorParams operatorParams_){
				
				InitInvocation("updateProtContract");
				
				updateProtContract_args args = new updateProtContract_args();
				args.SetProtContractMainInfoParams(protContractMainInfoParams_);
				args.SetProtContractDiscountInfoParams(protContractDiscountInfoParams_);
				args.SetOperatorParams(operatorParams_);
				
				SendBase(args, updateProtContract_argsHelper.getInstance());
			}
			
			
			private com.vip.api.promotion.vis.common.ResultModel recv_updateProtContract(){
				
				updateProtContract_result result = new updateProtContract_result();
				ReceiveBase(result, updateProtContract_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}