using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PmsActSiteModelHelper : TBeanSerializer<PmsActSiteModel>
	{
		
		public static PmsActSiteModelHelper OBJ = new PmsActSiteModelHelper();
		
		public static PmsActSiteModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PmsActSiteModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("siteId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSiteId(value);
					}
					
					
					
					
					
					if ("site".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSite(value);
					}
					
					
					
					
					
					if ("actScopeList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActScopeModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActScopeModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActScopeModel elem0;
								
								elem0 = new com.vip.pms.data.service.PmsActScopeModel();
								com.vip.pms.data.service.PmsActScopeModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetActScopeList(value);
					}
					
					
					
					
					
					if ("actPsScopeList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActPsScopeModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActPsScopeModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActPsScopeModel elem2;
								
								elem2 = new com.vip.pms.data.service.PmsActPsScopeModel();
								com.vip.pms.data.service.PmsActPsScopeModelHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetActPsScopeList(value);
					}
					
					
					
					
					
					if ("actFavList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActFavModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActFavModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActFavModel elem4;
								
								elem4 = new com.vip.pms.data.service.PmsActFavModel();
								com.vip.pms.data.service.PmsActFavModelHelper.getInstance().Read(elem4, iprot);
								
								value.Add(elem4);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetActFavList(value);
					}
					
					
					
					
					
					if ("actNoList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActNoModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActNoModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActNoModel elem6;
								
								elem6 = new com.vip.pms.data.service.PmsActNoModel();
								com.vip.pms.data.service.PmsActNoModelHelper.getInstance().Read(elem6, iprot);
								
								value.Add(elem6);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetActNoList(value);
					}
					
					
					
					
					
					if ("siteType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSiteType(value);
					}
					
					
					
					
					
					if ("actGoodsList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActGoodsModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActGoodsModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActGoodsModel elem8;
								
								elem8 = new com.vip.pms.data.service.PmsActGoodsModel();
								com.vip.pms.data.service.PmsActGoodsModelHelper.getInstance().Read(elem8, iprot);
								
								value.Add(elem8);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetActGoodsList(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(PmsActSiteModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSiteId() != null) {
				
				oprot.WriteFieldBegin("siteId");
				oprot.WriteI32((int)structs.GetSiteId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSite() != null) {
				
				oprot.WriteFieldBegin("site");
				oprot.WriteString(structs.GetSite());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("site can not be null!");
			}
			
			
			if(structs.GetActScopeList() != null) {
				
				oprot.WriteFieldBegin("actScopeList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActScopeModel _item0 in structs.GetActScopeList()){
					
					
					com.vip.pms.data.service.PmsActScopeModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActPsScopeList() != null) {
				
				oprot.WriteFieldBegin("actPsScopeList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActPsScopeModel _item0 in structs.GetActPsScopeList()){
					
					
					com.vip.pms.data.service.PmsActPsScopeModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actPsScopeList can not be null!");
			}
			
			
			if(structs.GetActFavList() != null) {
				
				oprot.WriteFieldBegin("actFavList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActFavModel _item0 in structs.GetActFavList()){
					
					
					com.vip.pms.data.service.PmsActFavModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actFavList can not be null!");
			}
			
			
			if(structs.GetActNoList() != null) {
				
				oprot.WriteFieldBegin("actNoList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActNoModel _item0 in structs.GetActNoList()){
					
					
					com.vip.pms.data.service.PmsActNoModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actNoList can not be null!");
			}
			
			
			if(structs.GetSiteType() != null) {
				
				oprot.WriteFieldBegin("siteType");
				oprot.WriteI32((int)structs.GetSiteType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActGoodsList() != null) {
				
				oprot.WriteFieldBegin("actGoodsList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActGoodsModel _item0 in structs.GetActGoodsList()){
					
					
					com.vip.pms.data.service.PmsActGoodsModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PmsActSiteModel bean){
			
			
		}
		
	}
	
}