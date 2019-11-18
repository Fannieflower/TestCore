using System;
using System.Collections.Generic;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	public interface ProtContractApiService {
		
		
		com.vip.api.promotion.vis.common.ResultModel addAttachment( List<com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentParams> protContractAttachmentParams_ );
		
		long? addProtContract( com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParams protContractMainInfoParams_,   List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams> protContractDiscountInfoParams_,   com.vip.api.promotion.vis.protcontract.service.OperatorParams operatorParams_ );
		
		com.vip.api.promotion.vis.common.ResultModel auditProtContract( com.vip.api.promotion.vis.protcontract.service.ProtContractAuditParams protContractAuditParams_ );
		
		List<com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailModel> batchGetProtContractDetail( com.vip.api.promotion.vis.protcontract.service.BatchProtContractDetailParam batchProtContractDetailParam_ );
		
		byte? checkBinding( long id_ );
		
		com.vip.api.promotion.vis.protcontract.service.VendorCaptchaActiveModel checkVendorCaptchaActive( int vendorCode_ );
		
		com.vip.api.promotion.vis.common.ResultModel deleteAttachment( long id_,   string userEmail_ );
		
		com.vip.api.promotion.vis.common.ResultModel deleteProtContract( long id_,   com.vip.api.promotion.vis.protcontract.service.OperatorParams operatorParams_ );
		
		com.vip.api.promotion.vis.common.FileFid exportCommodityList( com.vip.api.promotion.vis.protcontract.service.QueryActDetailParam queryActParam_ );
		
		com.vip.api.promotion.vis.common.FileFid exportProtContract( com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParam protContractQueryForAuditParam_ );
		
		com.vip.api.promotion.vis.common.TimedTaskResultModel fetchReminderJobSchedule();
		
		int? getAttachmentCount( long mainId_ );
		
		List<com.vip.api.promotion.vis.protcontract.service.ProtContractAttachmentModel> getAttachmentList( long mainId_ );
		
		List<com.vip.api.promotion.vis.protcontract.service.BrandGoods> getBrandGoodsList( long protId_ );
		
		com.vip.api.promotion.vis.common.ResultModel getCaptcha( com.vip.api.promotion.vis.protcontract.service.GetCaptchaParam getCaptchaParam_ );
		
		com.vip.api.promotion.vis.protcontract.service.ProtContractPageModel getContractPage( com.vip.api.promotion.vis.protcontract.service.ProtContractQueryParam protContractQueryParam_,   com.vip.api.promotion.vis.common.Pager pager_ );
		
		com.vip.api.promotion.vis.protcontract.service.ProtContractPageModel getContractPageForAudit( com.vip.api.promotion.vis.protcontract.service.ProtContractQueryForAuditParam protContractQueryForAuditParam_,   com.vip.api.promotion.vis.common.Pager pager_ );
		
		com.vip.api.promotion.vis.protcontract.service.ProtContractDetailModel getProtContractDetail( com.vip.api.promotion.vis.protcontract.service.ProtContractDetailParam protContractDetailParam_ );
		
		com.vip.api.promotion.vis.protcontract.service.ProtContractDetailPageModel getProtContractDetailPage( com.vip.api.promotion.vis.protcontract.service.ProtContractDetailQueryParams protContractDetailQueryParams_ );
		
		com.vip.api.promotion.vis.protcontract.service.ProtContractViewModel getProtContractView( long mainId_ );
		
		List<com.vip.api.promotion.vis.protcontract.service.VendorInfoModel> getVendorsByProtNos( List<string> protNos_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		bool? protContractLimitCheckVendorCodeInBlankList( string vendorCode_ );
		
		List<com.vip.api.promotion.vis.common.NameValueItem> queryActByActNo( com.vip.api.promotion.vis.protcontract.service.QueryActParam queryActParam_ );
		
		com.vip.api.promotion.vis.protcontract.service.ActivityModel queryActDetailByActNo( com.vip.api.promotion.vis.protcontract.service.QueryActDetailParam queryActParam_ );
		
		com.vip.api.promotion.vis.protcontract.service.SpecialNameListModel querySpecialName( com.vip.api.promotion.vis.third.service.QueryParam queryParam_ );
		
		com.vip.api.promotion.vis.common.ResultModel saveProtContractView( com.vip.api.promotion.vis.protcontract.service.ProtContractViewSaveParams protContractViewSaveParams_ );
		
		com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameResultModel searchSalesName( com.vip.api.promotion.vis.protcontract.service.ProtContractSalesNameParam protContractSalesNameParam_ );
		
		com.vip.api.promotion.vis.common.ResultModel setApps( long mainId_,   List<string> appValue_ );
		
		com.vip.api.promotion.vis.common.ResultModel submitProtContract( com.vip.api.promotion.vis.protcontract.service.ProtContractSubmitParam protContractSubmitParam_ );
		
		com.vip.api.promotion.vis.common.ResultModel updateProtContract( com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoParams protContractMainInfoParams_,   List<com.vip.api.promotion.vis.protcontract.service.ProtContractDiscountInfoParams> protContractDiscountInfoParams_,   com.vip.api.promotion.vis.protcontract.service.OperatorParams operatorParams_ );
		
	}
	
}