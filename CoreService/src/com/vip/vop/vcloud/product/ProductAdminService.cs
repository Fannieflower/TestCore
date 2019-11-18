using System;
using System.Collections.Generic;

namespace com.vip.vop.vcloud.product{
	
	
	public interface ProductAdminService {
		
		
		void deleteEmailConfig( string partnerId_,   string email_ );
		
		void deleteFileLogSettingByPrimaryKey( long id_ );
		
		void deleteHostByPrimaryKey( long id_ );
		
		void deleteProductByPartner( long partnerId_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
		List<com.vip.vop.vcloud.product.FileLogSetting> listAllFileLogSettings();
		
		List<com.vip.vop.vcloud.product.Host> listHosts( long partnerId_ );
		
		void pushPriceToVdgByIdList( List<string> idList_ );
		
		void pushProductToVdgBySkuIdList( List<string> skuIdList_ );
		
		void pushProductToVdgBySpuIdList( List<string> spuIdList_ );
		
		void saveEmailConfig( com.vip.vop.vcloud.product.EmailConfig config_ );
		
		void saveFileLogSetting( com.vip.vop.vcloud.product.FileLogSetting fileLogSetting_ );
		
		void saveHost( com.vip.vop.vcloud.product.Host host_ );
		
		List<string> testSftpConnectivity( string host_,   int port_,   string username_,   string password_ );
		
		void updateProductSku( string skuId_,   com.vip.vop.vcloud.product.Sku sku_ );
		
		void updateProductSkuAttr( string skuId_,   List<com.vip.vop.vcloud.product.Attribute> attributes_ );
		
		void updateProductSkuPrice( List<com.vip.vop.vcloud.product.SkuPrice> skuPrices_ );
		
		void updateProductSkuStatus( com.vip.vop.vcloud.product.ProductSkuStatus criteria_,   com.vip.vop.vcloud.product.ProductSkuStatus skuStatus_ );
		
		void updateProductSpu( string spuId_,   com.vip.vop.vcloud.product.Spu spu_ );
		
		void updateProductSpuAttr( string spuId_,   List<com.vip.vop.vcloud.product.Attribute> attributes_ );
		
		void updateSftpFileLog( List<string> logIdList_,   byte? logType_,   byte? status_ );
		
		void updateSpuImageUrl( string partnerId_,   string spu_,   string imgPath_,   string url_ );
		
	}
	
}