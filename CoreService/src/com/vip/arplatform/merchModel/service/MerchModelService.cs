using System;
using System.Collections.Generic;

namespace com.vip.arplatform.merchModel.service{
	
	
	public interface MerchModelService {
		
		
		void batchBind( long materialId_,   List<com.vip.arplatform.merchModel.service.BindingModel> bindingModels_ );
		
		bool? bind( long materialId_,   com.vip.arplatform.merchModel.service.BindingModel bindInfoModel_ );
		
		List<string> createBatchMaterial( List<com.vip.arplatform.merchModel.service.MaterialModel> mdList_ );
		
		void createMaterial( com.vip.arplatform.merchModel.service.MaterialModel md_ );
		
		int? deleteMaterialByBarcode( int serviceType_,   string _from_,   string barcode_ );
		
		int? deleteMaterialByMid( int serviceType_,   string _from_,   string mid_ );
		
		com.vip.arplatform.merchModel.service.BindingModel getBindInfoBySku( long sku_ );
		
		Dictionary<long?, List<long?>> getBindRelationship( List<long?> materialIds_ );
		
		com.vip.arplatform.merchModel.service.Jd3dModelAppResp getJd3dModel( string channel_,   string spu_,   string pidVid_ );
		
		com.vip.arplatform.merchModel.service.MaterialModel getMaterialModelById( long id_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		com.vip.arplatform.merchModel.service.PageableBindingModel searchBinding( com.vip.arplatform.merchModel.service.BindingSearchParams parameters_,   int page_,   int limit_,   string sortField_,   int? sort_ );
		
		com.vip.arplatform.merchModel.service.PageableMaterialModel searchMaterial( com.vip.arplatform.merchModel.service.MaterialSearchParams parameters_,   int page_,   int limit_,   string sortField_,   int? sort_ );
		
		bool? setBindingStatus( long sku_,   byte status_ );
		
		bool? setMaterialStatus( long materialId_,   byte status_ );
		
		com.vip.arplatform.merchModel.service.Jd3dModelSyncResponse syncFromJD( List<com.vip.arplatform.merchModel.service.Jd3dModelData> syncDatum_ );
		
		bool? unbind( long materialId_,   com.vip.arplatform.merchModel.service.BindingModel bindInfoModel_ );
		
	}
	
}